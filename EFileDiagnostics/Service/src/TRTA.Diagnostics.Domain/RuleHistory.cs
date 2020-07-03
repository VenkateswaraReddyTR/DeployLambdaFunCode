using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class RuleHistory
    {
        public RuleHistory(){
        }

        public virtual Guid Id { get; set; }
        public virtual Rule Rule { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime DateModified { get; set; }
        public virtual string ActionMessage { get; set; }   
    }
}
