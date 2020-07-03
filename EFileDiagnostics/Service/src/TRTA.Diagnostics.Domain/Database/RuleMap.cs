using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class RuleMap :ClassMap<Rule>
    {
        public RuleMap()
        {
            //Schema("brms");
            Table("\"Rule\"");

            Id(x => x.Id).Column("Id");
            Map(x => x.RuleNumber);
            References(x => x.ReturnType).Column("ReturnTypeId").LazyLoad(Laziness.False);
            HasManyToMany(x => x.SecondaryReturnTypes).Table("ruletosecondaryreturntype").ParentKeyColumn("RuleId").ChildKeyColumn("ReturnTypeId").Cascade.SaveUpdate();
            References(x => x.TaxAppYear).Column("TaxAppYearId").LazyLoad(Laziness.False);
            References(x => x.Jurisdiction).Column("JurisdictionId").LazyLoad(Laziness.False);
            HasManyToMany(x => x.SecondaryJurisdictions).Table("ruletosecondaryjurisdiction").ParentKeyColumn("RuleId").ChildKeyColumn("JurisdictionId").Cascade.SaveUpdate();
            Map(x => x.RuleText).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.AlternateText).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.JurisdictionStatus);
            Map(x => x.ModifiedBy);
            Map(x => x.DateModified);
            Map(x => x.IsDeleted);
            Map(x => x.IsActive);
            Map(x => x.Severity);
            References(x => x.TaxProfileArea).Column("TaxProfileAreaId").LazyLoad(Laziness.False).Nullable();
            Map(x => x.Logic).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.IsPublished);
            References(x => x.SchemaType).Column("SchemaTypeId").LazyLoad(Laziness.False);
            Map(x => x.LinkedQuery).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.XQuery).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.UseAtLeast);
            Map(x => x.PlaceholderFields);
            Map(x => x.Precision).Column("\"Precision\"");
            Map(x => x.Status);
            HasManyToMany(x => x.Categories).Table("RuleToCategory").ParentKeyColumn("RuleId").ChildKeyColumn("CategoryId").Cascade.SaveUpdate();
            HasManyToMany(x => x.Fields).Table("RuleToField").ParentKeyColumn("RuleId").ChildKeyColumn("FieldId").Cascade.SaveUpdate();
            HasMany(x => x.CustomFieldValues).Cascade.AllDeleteOrphan().Fetch.Join().Inverse().KeyColumn("RuleId");
        }
    }
}
