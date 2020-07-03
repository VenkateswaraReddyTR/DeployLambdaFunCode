using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class Field
    {
        public Field()
        {
        }

        public Field(int Id, string name, string Xpath)
        {
            this.Id = Id;
            this.name = name;
            this.Xpath = Xpath;
        }

        public virtual int Id{ get; set; }
        public virtual int Area{ get; set; }
        public virtual int Screen{ get; set; }
        public virtual int field{ get; set; }
        public virtual string typedesc{ get; set; }
        public virtual string Eorg{ get; set; }
        public virtual string name{ get; set; }
        public virtual string Annotation{ get; set; }
        public virtual ReturnType ReturnType{ get; set; }
        public virtual IList<TaxAppYear> TaxAppYears{ get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
        public virtual bool IsElement { get; set; }
        public virtual string Xpath{ get; set; }
        public virtual EfileSchemaType SchemaType { get; set; }
        public virtual string MinOccurs { get; set; }
        public virtual string MaxOccurs { get; set; }
        public virtual bool ? IsSimpleType { get; set; }
        public virtual string FormName { get; set; }
        public virtual DateTime DateModified { get; set; }

        public virtual Domain.PurgeField toPurge()
        {
            Domain.PurgeField purgeField = new Domain.PurgeField();
            purgeField.Id = this.Id;
            purgeField.Area = this.Area;
            purgeField.Screen = this.Screen;
            purgeField.field = this.field;
            purgeField.typedesc = this.typedesc;
            purgeField.Eorg = this.Eorg;
            purgeField.name = this.name;
            purgeField.Annotation = this.Annotation;
            purgeField.ReturnTypeId = this.ReturnType.Id;
            purgeField.JurisdictionId = this.Jurisdiction.Id;
            purgeField.IsElement = this.IsElement;
            purgeField.Xpath = this.Xpath;
            purgeField.SchemaTypeId = this.SchemaType.Id;
            purgeField.MinOccurs = this.MinOccurs;
            purgeField.MaxOccurs = this.MaxOccurs;
            purgeField.IsSimpleType = this.IsSimpleType;
            purgeField.FormName = this.FormName;
            purgeField.DateModified = DateTime.Now;
            return purgeField;
        }
    }
}
