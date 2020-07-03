using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace TRTA.Diagnostics.Domain.Database
{
    class RuleHeaderMap : ClassMap<RuleHeader>
    {
        public RuleHeaderMap()
        {
            //Schema("brms");
            Table("RuleHeader");

            Id(x => x.Id).Column("Id");
            References(x => x.ReturnType).Column("ReturnTypeId").LazyLoad(Laziness.False);
            References(x => x.TaxAppYear).Column("TaxAppYearId").LazyLoad(Laziness.False);
            References(x => x.Jurisdiction).Column("JurisdictionId").LazyLoad(Laziness.False);
            Map(x => x.RuleNumber);
            Map(x => x.RuleText);
            Map(x => x.Severity);
            Map(x => x.JurisdictionStatus);
            References(x => x.FileFormat).Column("FileFormatId").LazyLoad(Laziness.False);
        }
    }
}
