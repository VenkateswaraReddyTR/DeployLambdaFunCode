using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class Category
    {
        public Category()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        //public virtual IList<Rule> Rules { get; set; }
        //public virtual IList<PurgeRule> PurgeRules { get; set; }
    }
}
