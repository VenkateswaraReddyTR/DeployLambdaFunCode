using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class Locator
    {
        public Locator()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string ReturnType { get; set; }
        public virtual string TaxAppYear { get; set; }        
        public virtual string Name { get; set; }
        public virtual string Jurisdiction { get; set; }
    }
}
