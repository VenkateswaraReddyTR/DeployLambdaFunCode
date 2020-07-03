using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain
{
    public class PurgeRule
    {
        public PurgeRule()
        {
        }
        public virtual Guid Id { get; set; }
        public virtual string RuleNumber { get; set; }
        public virtual Guid ReturnTypeId { get; set; }
        public virtual IList<ReturnType> SecondaryReturnTypes { get; set; }
        public virtual Guid TaxAppYearId { get; set; }
        public virtual Guid JurisdictionId { get; set; }
        public virtual IList<Jurisdiction> SecondaryJurisdictions { get; set; }
        public virtual string RuleText { get; set; }
        public virtual string AlternateText { get; set; }
        public virtual string JurisdictionStatus { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime DateModified { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsPublished { get; set; } 
        public virtual string Severity { get; set; }
        public virtual Guid? TaxProfileAreaId { get; set; }
        public virtual string Logic { get; set; }
        public virtual Guid SchemaTypeId { get; set; }
        public virtual string LinkedQuery { get; set; }
        public virtual string XQuery { get; set; }
        public virtual int UseAtLeast { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual string PlaceholderFields { get; set; }
        public virtual int? Precision { get; set; }
        public virtual string Status { get; set; }
    }
}
