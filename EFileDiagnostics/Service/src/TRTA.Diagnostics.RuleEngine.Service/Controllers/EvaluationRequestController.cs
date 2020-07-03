using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Repository;

namespace TRTA.Diagnostics.RuleEngine.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationRequestController : BaseController
    {
        private IEvaluationRequestService _evaluationRequestService;
        private string RequestedBy = string.Empty;
        private string _userName;
        private IRuleService _ruleService;
        private IRuleLogService _ruleLogService;
        private ISchemaTypeService _schemaTypeService;
        private readonly ILogger<EvaluationRequestController> _logger;
        private IRuleExecutionLogService _ruleExecutionLogService;
        private IConfiguration _configuration;

        public EvaluationRequestController(IEvaluationRequestService evaluationRequestService, ILogger<EvaluationRequestController> logger, IRuleService ruleService, IRuleLogService ruleLogService, ISchemaTypeService schemaTypeService, IRuleExecutionLogService ruleExecutionLogService, IConfiguration configuration)
        {
            _logger = logger;
            _logger.LogInformation("Getting the user name from HTTPContext");
            _evaluationRequestService = evaluationRequestService;
            _ruleService = ruleService;
            _ruleLogService = ruleLogService;
            _schemaTypeService = schemaTypeService;
            _ruleExecutionLogService = ruleExecutionLogService;
            _configuration = configuration;
        }

        [HttpPost]
        [EnableCors]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PostAsync(EvaluationRequest evaluationRequest, IFormFile file)
        {
            _logger.LogInformation("CreateEvaluationRequest start");
            _logger.LogInformation($"CreateEvaluationRequest year:{0}, returnType:{1}, jurisdiction:{2}, locator:{3}, schemaType:{4}", evaluationRequest.TaxAppYear, evaluationRequest.ReturnType, evaluationRequest.Jurisdiction, evaluationRequest.Locator, evaluationRequest.SchemaType);
            Domain.EvaluationRequest tempEvaluationRequest = null;
            int id = -1;
            try
            {
                string fileName = "";
                int fileSize = 0;
                bool hasRules = true;
                _userName = string.Empty;//Thread.CurrentPrincipal.Identity.Name;
                string pathForSaving = _configuration["EvaluationRequestXMLPath"].ToString();
                hasRules = await _ruleService.CheckRulesExistAsync(evaluationRequest.TaxAppYear, evaluationRequest.ReturnType, evaluationRequest.Jurisdiction, evaluationRequest.SchemaType, true, true, false, true);
                var request = new Domain.EvaluationRequest()
                {
                    TaxAppYear = evaluationRequest.TaxAppYear,
                    ReturnType = evaluationRequest.ReturnType,
                    Jurisdiction = evaluationRequest.Jurisdiction,
                    Locator = evaluationRequest.Locator,
                    SchemaType = evaluationRequest.SchemaType,
                    DocumentToEvaluate = fileName,
                    RequestStatus = hasRules ? RequestStatusConstants.PENDING : RequestStatusConstants.COMPLETED,
                    DateOfCreation = DateTime.Now,
                    DateModified = DateTime.Now,
                    InstanceName = "",
                    RequestedBy = _userName,
                    FileSize = fileSize
                };
                await _evaluationRequestService.SaveAsync(request, file);
                id = request.Id;
                if (!hasRules)
                {
                    Guid LocatorId = _ruleLogService.GetOrSaveLocator(evaluationRequest.TaxAppYear, evaluationRequest.Jurisdiction, evaluationRequest.ReturnType, evaluationRequest.Locator).Id;
                }

                //clear the documentXML of the return object so the return object can be more light
                tempEvaluationRequest = new Domain.EvaluationRequest()
                {
                    TaxAppYear = evaluationRequest.TaxAppYear,
                    ReturnType = evaluationRequest.ReturnType,
                    Jurisdiction = evaluationRequest.Jurisdiction,
                    Locator = evaluationRequest.Locator,
                    SchemaType = evaluationRequest.SchemaType,
                    DocumentToEvaluate = "",
                    RequestStatus = request.RequestStatus,
                    DateOfCreation = request.DateOfCreation,
                    DateModified = request.DateModified,
                    InstanceName = request.InstanceName,
                    FileSize = fileSize,
                    Id = request.Id
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in CreateEvaluationRequest method");
                tempEvaluationRequest = new Domain.EvaluationRequest()
                {
                    RequestStatus = "FAILED",
                    Id = -1
                };
            }
            return Created($"{Request.Path}/{id}", evaluationRequest);
        }


        [HttpGet]
        public async Task<IActionResult> GetDiagnosticsAsync(int Id)

        {
            _logger.LogInformation("GetDiagnostics start ");
            _logger.LogInformation(String.Format("GetDiagnostics id:{0}", Id));
            List<PlatformDiagnosticsResponse> DiagnosticsResponseList = new List<PlatformDiagnosticsResponse>();
            try
            {
                var evaluationRequest = _evaluationRequestService.Get(Id);
                if (evaluationRequest.RequestStatus == RequestStatusConstants.COMPLETED)
                {
                    DiagnosticsResponseList = _ruleExecutionLogService.FormatLogsToPlatform(evaluationRequest);

                    return Ok(DiagnosticsResponseList);
                }
                else
                {
                    PlatformDiagnosticsResponse responseItem = new PlatformDiagnosticsResponse();
                    responseItem.ReturnType = evaluationRequest.ReturnType;
                    responseItem.Jurisdiction = evaluationRequest.Jurisdiction;
                    responseItem.TaxAppYear = evaluationRequest.TaxAppYear;
                    responseItem.StartDate = evaluationRequest.DateOfCreation;
                    responseItem.EndDate = evaluationRequest.DateModified;
                    responseItem.Status = evaluationRequest.RequestStatus;
                    responseItem.SchemaType = evaluationRequest.SchemaType;
                    responseItem.FileSize = evaluationRequest.FileSize;
                    responseItem.ExecutionLogs = null;
                    DiagnosticsResponseList.Add(responseItem);
                    return Ok(DiagnosticsResponseList);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in GetDiagnostics By Id method");
                return StatusCode(500, ex);
            }

        }

    }
}