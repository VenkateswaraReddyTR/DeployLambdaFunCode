using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class ReturnType
    {
        public ReturnType()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        [IgnoreDataMember]
        public virtual IList<Jurisdiction> Jurisdictions { get; set; }
    }
}
