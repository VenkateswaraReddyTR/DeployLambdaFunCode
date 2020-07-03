using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class CustomFieldValues
    {
        public CustomFieldValues()
        { 
        }

        public virtual Guid Id { get; set; }
        public virtual CustomFieldMapping CustomFieldMapping { get; set; }
        public virtual Rule Rule { get; set; }
        public virtual string Value { get; set; }
    }
}
