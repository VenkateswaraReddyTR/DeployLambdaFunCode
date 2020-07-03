using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class DiagnosticsViewerRuleStateMap : ClassMap<DiagnosticsViewerRuleState>
    {
        public DiagnosticsViewerRuleStateMap()
        {
            //Schema("brms");
            Table("[DiagnosticsViewerRuleState]");

            Id(x => x.Id).Column("Id");
            References(x => x.Locator).Column("LocatorId").LazyLoad(Laziness.False);
            References(x => x.Rule).Column("RuleId").LazyLoad(Laziness.False);
            Map(x => x.Hidden);
            Map(x => x.EvaluationId);
        }
    }
}
