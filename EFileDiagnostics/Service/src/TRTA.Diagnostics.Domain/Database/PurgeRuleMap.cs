using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class PurgeRuleMap : ClassMap<PurgeRule>
    {
        public PurgeRuleMap()
        {
            //Schema("brms");
            Table("[PurgeRule]");

            Id(x => x.Id).Column("Id").GeneratedBy.Assigned();
            Map(x => x.RuleNumber);
            Map(x => x.ReturnTypeId);
            HasManyToMany(x => x.SecondaryReturnTypes).Table("PurgeRuleToSecondaryReturnType").ParentKeyColumn("RuleId").ChildKeyColumn("ReturnTypeId").Cascade.SaveUpdate();
            Map(x => x.JurisdictionId);
            HasManyToMany(x => x.SecondaryJurisdictions).Table("PurgeRuleToSecondaryJurisdiction").ParentKeyColumn("RuleId").ChildKeyColumn("JurisdictionId").Cascade.SaveUpdate();
            Map(x => x.TaxAppYearId);
            Map(x => x.RuleText).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.AlternateText).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.JurisdictionStatus);
            Map(x => x.ModifiedBy);
            Map(x => x.DateModified);
            Map(x => x.IsDeleted);
            Map(x => x.IsActive);
            Map(x => x.Severity);
            Map(x => x.TaxProfileAreaId).Nullable();
            Map(x => x.Logic).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.IsPublished);
            Map(x => x.SchemaTypeId);
            Map(x => x.UseAtLeast);
            Map(x => x.LinkedQuery).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.XQuery).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.PlaceholderFields);
            Map(x => x.Precision);
            Map(x => x.Status);
            HasManyToMany(x => x.Categories).Table("PurgeRuleToCategory").ParentKeyColumn("PurgeRuleId").ChildKeyColumn("CategoryId").Cascade.SaveUpdate();
        }
    }
}
