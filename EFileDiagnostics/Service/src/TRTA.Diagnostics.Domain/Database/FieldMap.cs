using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class FieldMap : ClassMap<Field>
    {
        public FieldMap()
        {
            //Schema("brms");
            Table("[Field]");

            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Area);
            Map(x => x.Screen);
            Map(x => x.field);
            Map(x => x.typedesc);
            Map(x => x.Eorg);
            Map(x => x.name);
            Map(x => x.Annotation);
            References(x => x.ReturnType).Column("ReturnTypeId").LazyLoad(Laziness.False);
            HasManyToMany(x => x.TaxAppYears).Table("FieldToTaxAppYear").ParentKeyColumn("FieldId").ChildKeyColumn("TaxAppYearId").Cascade.SaveUpdate().Not.LazyLoad();
            References(x => x.Jurisdiction).Column("JurisdictionId").LazyLoad(Laziness.False);
            References(x => x.SchemaType).Column("SchemaTypeId").LazyLoad(Laziness.False);
            Map(x => x.Xpath).CustomType("AnsiString");
            Map(x => x.MinOccurs);
            Map(x => x.MaxOccurs);
            Map(x => x.IsSimpleType);
            Map(x => x.IsElement);
            Map(x => x.FormName);
            Map(x => x.DateModified);
            Cache.ReadWrite().Region("ReadWriteRegion");
        }
    }
}
