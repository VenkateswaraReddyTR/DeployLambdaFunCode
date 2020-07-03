using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PlatformExecutionLog
    {
        public PlatformExecutionLog()
        {
        }
        public virtual string RuleId { get; set; }
        public virtual string RuleNumber { get; set; }
        public virtual string FormattedText { get; set; }
        public virtual string GoTo { get; set; }
        public virtual string Category { get; set; }
        public virtual string Type { get; set; }
    }
}
