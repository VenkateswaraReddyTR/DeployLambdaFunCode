using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class EvaluationRequestService : BaseService, IEvaluationRequestService
    {
        private IFileRepository _fileRepository;

        public EvaluationRequestService(IRepository repository, IFileRepository fileRepository) : base(repository)
        {
            _fileRepository = fileRepository;
        }
        public async Task SaveAsync(EvaluationRequest evaluationRequest, IFormFile formFile)
        {
            await _fileRepository.PutFileAsync(formFile.FileName, formFile);
            //evaluationRequest.DocumentToEvaluate = formFile.FileName;
            //evaluationRequest.FileSize = formFile.Length;
            //evaluationRequest.DateOfCreation = DateTime.Now;
            //evaluationRequest.DateModified = DateTime.Now;
            //evaluationRequest.RequestStatus = RequestStatusConstants.PENDING;
            //evaluationRequest.InstanceName = "";
            //_repository.Save(evaluationRequest);
        }
        public virtual EvaluationRequest Get(int Id)
        {
            return _repository.Get<EvaluationRequest>(Id);
        }
    }
}
