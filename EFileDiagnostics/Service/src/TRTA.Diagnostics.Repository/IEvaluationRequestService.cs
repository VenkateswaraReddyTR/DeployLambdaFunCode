using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Repository
{
    public interface IEvaluationRequestService
    {
        Task SaveAsync(EvaluationRequest evaluationRequest, IFormFile formFile);
        EvaluationRequest Get(int Id);
    }
}
