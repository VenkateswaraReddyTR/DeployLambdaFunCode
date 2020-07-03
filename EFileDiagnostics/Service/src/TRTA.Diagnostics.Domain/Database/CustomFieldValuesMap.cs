using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace TRTA.Diagnostics.Domain.Database
{
    class CustomFieldValuesMap : ClassMap<CustomFieldValues>
    {
        public CustomFieldValuesMap()
        {
            //Schema("brms");
            Table("CustomFieldValues");

            Id(x => x.Id).Column("Id");
            References(x => x.Rule).Not.Nullable().Cascade.SaveUpdate().Column("RuleId");
            References(x => x.CustomFieldMapping).Not.Nullable().Cascade.SaveUpdate().Column("CustomFieldMappingId");
            Map(x => x.Value);
        }
    }
}
