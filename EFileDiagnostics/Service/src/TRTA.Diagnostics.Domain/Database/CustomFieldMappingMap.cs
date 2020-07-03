using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace TRTA.Diagnostics.Domain.Database
{
    class CustomFieldMappingMap : ClassMap<CustomFieldMapping>
    {
        public CustomFieldMappingMap()
        {
            //Schema("brms");
            Table("CustomFieldMapping");

            Id(x => x.Id).Column("Id");
            References(x => x.ReturnType).Column("ReturnTypeId").LazyLoad(Laziness.False);
            References(x => x.TaxAppYear).Column("TaxAppYearId").LazyLoad(Laziness.False);
            References(x => x.Jurisdiction).Column("JurisdictionId").LazyLoad(Laziness.False);
            Map(x => x.FieldName);
            Map(x => x.MappingField);
            HasMany(x => x.CustomFieldValues).Cascade.AllDeleteOrphan().Inverse().KeyColumn("CustomFieldMappingId");
        }
    }
}
