using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class CustomFieldMapping
    {
        public CustomFieldMapping()
        { 
        }

        public virtual Guid Id { get; set; }
        public virtual ReturnType ReturnType { get; set; }
        public virtual TaxAppYear TaxAppYear { get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
        public virtual string FieldName { get; set; }
        public virtual string MappingField { get; set; }
        public virtual IList<CustomFieldValues> CustomFieldValues { get; set; }
    }
}
