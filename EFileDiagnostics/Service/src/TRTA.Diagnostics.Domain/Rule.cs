using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain
{
    public class Rule
    {
        public Rule()
        {
            SecondaryReturnTypes = new List<ReturnType>();
            SecondaryJurisdictions = new List<Jurisdiction>();
            Categories = new List<Category>();
            Fields = new List<Field>();
            CustomFieldValues = new List<CustomFieldValues>();
        }

        public virtual Guid Id { get; set; }
        public virtual string RuleNumber { get; set; }
        public virtual ReturnType ReturnType { get; set; }
        public virtual IList<ReturnType> SecondaryReturnTypes { get; set; }
        public virtual TaxAppYear TaxAppYear { get; set; }
        public virtual Jurisdiction Jurisdiction { get; set; }
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
        public virtual TaxProfileArea TaxProfileArea { get; set; }
        public virtual string Logic { get; set; }
        public virtual IList<CustomFieldValues> CustomFieldValues { get; set; }
        public virtual EfileSchemaType SchemaType { get; set; }
        public virtual string LinkedQuery { get; set; }
        public virtual IList<Category> Categories { get; set; }
        public virtual string XQuery { get; set; }
        public virtual int UseAtLeast { get; set; }
        public virtual string PlaceholderFields { get; set; }
        public virtual int? Precision { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<Field> Fields { get; set; }

        public virtual Domain.PurgeRule toPurge(string PModifiedBy)
        {
            Domain.PurgeRule purgerule = new Domain.PurgeRule();
            purgerule.Id = this.Id;
            purgerule.RuleNumber = this.RuleNumber;
            purgerule.ReturnTypeId = this.ReturnType.Id;
            purgerule.SecondaryReturnTypes = new List<ReturnType>();
            if (SecondaryReturnTypes != null)
                this.SecondaryReturnTypes.ToList().ForEach(r => purgerule.SecondaryReturnTypes.Add(r));
            purgerule.TaxAppYearId = this.TaxAppYear.Id;
            purgerule.JurisdictionId = this.Jurisdiction.Id;
            purgerule.SecondaryJurisdictions = new List<Jurisdiction>();
            if (SecondaryJurisdictions != null)
                this.SecondaryJurisdictions.ToList().ForEach(j => purgerule.SecondaryJurisdictions.Add(j));
            purgerule.RuleText = this.RuleText;
            purgerule.JurisdictionStatus = this.JurisdictionStatus;
            purgerule.ModifiedBy = PModifiedBy;
            purgerule.DateModified = DateTime.Now;
            purgerule.IsDeleted = this.IsDeleted;
            purgerule.IsActive = this.IsActive;
            purgerule.Severity = this.Severity;
            if (this.TaxProfileArea != null)
                purgerule.TaxProfileAreaId = this.TaxProfileArea.Id;
            purgerule.IsPublished = this.IsPublished;
            purgerule.Logic = this.Logic;
            purgerule.SchemaTypeId = this.SchemaType.Id;
            purgerule.LinkedQuery = this.LinkedQuery;
            purgerule.Categories = new List<Category>();
            purgerule.XQuery = this.XQuery;
            purgerule.UseAtLeast = this.UseAtLeast;
            purgerule.PlaceholderFields = this.PlaceholderFields;
            purgerule.Precision = this.Precision;
            purgerule.Status = this.Status;
            this.Categories.ToList().ForEach(c => purgerule.Categories.Add(c));
            return purgerule;
        }

        public virtual Rule Copy()
        {
            Rule NewRule = new Rule
            {
                RuleNumber = this.RuleNumber,
                ReturnType = this.ReturnType,
                TaxAppYear = this.TaxAppYear,
                Jurisdiction = this.Jurisdiction,
                RuleText = this.RuleText,
                AlternateText = this.AlternateText,
                JurisdictionStatus = this.JurisdictionStatus,
                ModifiedBy = this.ModifiedBy,
                DateModified = DateTime.Now,
                IsDeleted = this.IsDeleted,
                IsActive = this.IsActive,
                IsPublished = this.IsPublished,
                Severity = this.Severity,
                TaxProfileArea = this.TaxProfileArea,
                Logic = this.Logic,
                SchemaType = this.SchemaType,
                LinkedQuery = this.LinkedQuery,
                XQuery = string.Empty,
                UseAtLeast = this.UseAtLeast,
                PlaceholderFields = this.PlaceholderFields,
                Precision = this.Precision,
                Status = this.Status,
            };

            if (this.SecondaryReturnTypes != null)
                this.SecondaryReturnTypes.ToList().ForEach(r => NewRule.SecondaryReturnTypes.Add(r));
            if (this.SecondaryJurisdictions != null)
                this.SecondaryJurisdictions.ToList().ForEach(j => NewRule.SecondaryJurisdictions.Add(j));
            if (this.CustomFieldValues != null)
                this.CustomFieldValues.ToList().ForEach(j => NewRule.CustomFieldValues.Add(j));
            if (this.Categories != null)
                this.Categories.ToList().ForEach(j => NewRule.Categories.Add(j));
            if (this.Fields != null)
                this.Fields.ToList().ForEach(j => NewRule.Fields.Add(j));

            return NewRule;
        }
    }
}
