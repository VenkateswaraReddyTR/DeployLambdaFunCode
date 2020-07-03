using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class Jurisdiction
    {
        public Jurisdiction()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual String Name { get; set; }
        public virtual Country Country { get; set; }
        public virtual String ShortName { get; set; }
        public virtual JurisdictionType JurisdictionType { get; set; }
    }
}
