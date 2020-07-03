using System;
using System.Collections.Generic;
using System.Text;
using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Repository
{
    public interface IRuleExecutionLogService
    {
        List<PlatformDiagnosticsResponse> FormatLogsToPlatform(EvaluationRequest evaluationRequest);
    }
}
