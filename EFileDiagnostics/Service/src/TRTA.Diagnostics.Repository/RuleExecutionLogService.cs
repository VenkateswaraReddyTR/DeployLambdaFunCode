using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class RuleExecutionLogService : BaseService, IRuleExecutionLogService
    {
        private ILogger<RuleLogService> _logger;

        public RuleExecutionLogService(IRepository repository, ILogger<RuleLogService> logger)
               : base(repository)
        {
            _logger = logger;
        }

        public List<PlatformDiagnosticsResponse> FormatLogsToPlatform(EvaluationRequest evaluationRequest)
        {
            List<PlatformDiagnosticsResponse> responseList = new List<PlatformDiagnosticsResponse>();
            var diagInfo = GetDiagDetailsByEvaluationRequestId(evaluationRequest.Id);
            if (diagInfo != null && diagInfo.Any())
            {
                foreach (var item in diagInfo)
                {
                    PlatformDiagnosticsResponse responseItem = new PlatformDiagnosticsResponse();
                    responseItem.ReturnType = item.Locator.ReturnType;
                    responseItem.Jurisdiction = item.Locator.Jurisdiction;
                    responseItem.TaxAppYear = item.Locator.TaxAppYear;
                    responseItem.StartDate = evaluationRequest.DateOfCreation;
                    responseItem.EndDate = item.Endtime;
                    responseItem.Status = item.Status;
                    responseItem.SchemaType = item.SchemaType.Name;
                    responseItem.FileSize = evaluationRequest.FileSize;
                    responseItem.ExecutionLogs = new List<PlatformExecutionLog>();
                    List<DiagnosticsInfo> executionLogs = JsonConvert.DeserializeObject<List<DiagnosticsInfo>>(((!string.IsNullOrEmpty(item.DiagnosticInfo))) ? item.DiagnosticInfo : string.Empty);
                    if (executionLogs != null && executionLogs.Any())
                    {
                        executionLogs = executionLogs.OrderBy(x => x.RuleNumber).ToList();

                        foreach (DiagnosticsInfo exLogs in executionLogs)
                        {
                            string[] goToArray = exLogs.GoTo != null ? exLogs.GoTo.Split(',') : new string[1];
                            bool canCompareGoto = false;
                            bool canCompareFieldKey = false;
                            if (goToArray.Length >= 2) { canCompareGoto = true; }

                            foreach (var ft in exLogs.FormattedTexts ?? new List<FormattedRuleText>())
                            {
                                string matchedFieldKey = "";

                                foreach (var log in exLogs.Log)
                                {
                                    if ((log.evaluationId == ft.evaluationId))
                                    {
                                        foreach (LogEntry logEntry in log.logEntries)
                                        {
                                            string[] fieldKeyArray = logEntry.fieldKey != null ? logEntry.fieldKey.Split(',') : new string[1];

                                            if (fieldKeyArray.Length >= 2) { canCompareFieldKey = true; }

                                            if ((canCompareGoto) && (canCompareFieldKey))
                                            {
                                                if ((goToArray[0] == fieldKeyArray[0]) && (goToArray[1] == fieldKeyArray[1]) && (goToArray[2] == fieldKeyArray[2]))
                                                {
                                                    matchedFieldKey = logEntry.fieldKey;
                                                }
                                            }
                                        }
                                    }
                                }

                                PlatformExecutionLog executionLogItem = new PlatformExecutionLog();
                                executionLogItem.RuleId = exLogs.RuleId;
                                executionLogItem.RuleNumber = "* " + exLogs.RuleNumber;
                                executionLogItem.FormattedText = exLogs.FormattedTexts.Count > 0 ? ft.formattedRuleText : "";
                                executionLogItem.GoTo = matchedFieldKey == "" ? exLogs.GoTo : matchedFieldKey;
                                executionLogItem.Category = exLogs.Categories.Count > 0 ? exLogs.Categories[0].Name : "";
                                executionLogItem.Type = executionLogItem.Category != "" ? GetCategoryType(executionLogItem.Category) : "";
                                responseItem.ExecutionLogs.Add(executionLogItem);
                            }
                        }
                    }
                    responseList.Add(responseItem);
                }
            }
            else
            {
                responseList = null;
            }

            return responseList;

        }

        private IEnumerable<RuleExecutionLog> GetDiagDetailsByEvaluationRequestId(int EvaluationRequestId)
        {
            var RuleExecutionLog = _repository.GetAll<RuleExecutionLog>().Where(x => x.EvaluationRequest.Id.Equals(EvaluationRequestId) && x.Status.Equals("Success")).OrderByDescending(o => o.StartTime).Take(1);
            return RuleExecutionLog;
        }

        private string GetCategoryType(string category)
        {
            string typeCategory = "";
            List<PlatformCategoryType> list = new List<PlatformCategoryType>();
            PlatformCategoryType type = new PlatformCategoryType();
            type.CategoryName = "Annual Stmt E-File Alerts";
            type.TypeValue = "J";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "Annual Stmt E-File Rejects";
            type.TypeValue = "O";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "E-File Alert";
            type.TypeValue = "W";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "E-File Extension Reject";
            type.TypeValue = "H";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "E-File Return Reject";
            type.TypeValue = "G";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "E-File Estimate Reject";
            type.TypeValue = "U";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "Informational";
            type.TypeValue = "D";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "Mandatory";
            type.TypeValue = "P";
            list.Add(type);
            type = new PlatformCategoryType();
            type.CategoryName = "Severe";
            type.TypeValue = "T";
            list.Add(type);
            foreach (var item in list)
            {
                if (item.CategoryName == category)
                {
                    typeCategory = item.TypeValue;
                }
            }
            return typeCategory;
        }
    }
}
