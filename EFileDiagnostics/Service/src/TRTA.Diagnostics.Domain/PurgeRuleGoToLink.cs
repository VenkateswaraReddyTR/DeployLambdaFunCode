using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PurgeRuleGoToLink
    {
        public PurgeRuleGoToLink()
        {
        }

        public virtual Guid Id { get; set; }
        public virtual Rule Rule { get; set; }
        public virtual string Area { get; set; }
        public virtual string Screen { get; set; }
        public virtual string Field { get; set; }
    }
}
