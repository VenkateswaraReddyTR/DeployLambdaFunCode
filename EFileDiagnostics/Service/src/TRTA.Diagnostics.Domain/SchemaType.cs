using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class EfileSchemaType
    {
        public EfileSchemaType()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
