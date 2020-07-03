using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class TaxAppYear
    {
        public TaxAppYear()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string Year { get; set; }
    }
}
