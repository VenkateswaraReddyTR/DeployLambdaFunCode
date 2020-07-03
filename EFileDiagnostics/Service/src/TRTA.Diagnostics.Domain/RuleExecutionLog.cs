using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class RuleExecutionLog
    {
        public RuleExecutionLog()
        {
        }
        public virtual Guid Id { get; set; }       
        public virtual Locator Locator { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime? Endtime { get; set; }
        public virtual string Status { get; set; }
        public virtual string DiagnosticInfo { get; set; }
        public virtual EfileSchemaType SchemaType { get; set; }
        public virtual EvaluationRequest EvaluationRequest { get; set; }
    }
}
