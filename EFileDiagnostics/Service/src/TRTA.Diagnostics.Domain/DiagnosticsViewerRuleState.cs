using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class DiagnosticsViewerRuleState
    {
        public DiagnosticsViewerRuleState()
        {
        }

        public virtual Guid Id { get; set; }
        public virtual Rule Rule { get; set; }
        public virtual Locator Locator { get; set; }
        public virtual bool Hidden { get; set; }
        public virtual int EvaluationId { get; set; }
    }
}
