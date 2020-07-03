using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class RuleHeader
    {
        public RuleHeader()
        {
        }

        public virtual Guid Id { get; set; }
        public virtual ReturnType ReturnType { get; set; }
        public virtual TaxAppYear TaxAppYear { get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
        public virtual string RuleNumber { get; set; }
        public virtual string RuleText { get; set; }
        public virtual string Severity { get; set; }
        public virtual string JurisdictionStatus { get; set; }
        public virtual FileFormat FileFormat { get; set; }
    }
}
