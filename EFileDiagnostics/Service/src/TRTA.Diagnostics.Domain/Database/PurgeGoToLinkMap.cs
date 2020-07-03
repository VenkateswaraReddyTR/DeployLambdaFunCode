using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class GoToLinkPurgeMap: ClassMap<PurgeRuleGoToLink>
    {
        public GoToLinkPurgeMap()
        {
            //Schema("brms");
            Table("PurgeRuleGoToLink");
            Id(x => x.Id).Column("Id");
            References(x => x.Rule).Column("RuleId").LazyLoad(Laziness.False);
            Map(x => x.Area);
            Map(x => x.Screen);
            Map(x => x.Field);
        }
    }
}
