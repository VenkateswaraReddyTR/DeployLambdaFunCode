using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class PurgeField
    {
        public PurgeField()
        {
        }
        public virtual int Id{ get; set; }
        public virtual int Area{ get; set; }
        public virtual int Screen{ get; set; }
        public virtual int field{ get; set; }
        public virtual string typedesc{ get; set; }
        public virtual string Eorg{ get; set; }
        public virtual string name{ get; set; }
        public virtual string Annotation{ get; set; }
        public virtual Guid ReturnTypeId { get; set; }
        public virtual string Xpath{ get; set; }
        public virtual Guid JurisdictionId { get; set; }
        public virtual bool IsElement { get; set; }
        public virtual Guid SchemaTypeId { get; set; }
        public virtual string MinOccurs { get; set; }
        public virtual string MaxOccurs { get; set; }
        public virtual bool ? IsSimpleType { get; set; }
        public virtual string FormName { get; set; }
        public virtual DateTime DateModified { get; set; }
    }
}
