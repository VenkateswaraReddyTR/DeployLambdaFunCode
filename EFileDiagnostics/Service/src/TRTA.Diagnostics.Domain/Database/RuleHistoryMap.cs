using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class RuleHistoryMap :ClassMap<RuleHistory>
    {
        public RuleHistoryMap()
        {
            //Schema("brms");
            Table("[RuleHistory]");

            Id(x => x.Id).Column("Id");
            Map(x => x.ModifiedBy);
            Map(x => x.DateModified);
            Map(x => x.ActionMessage);
            References(x => x.Rule).Column("RuleId").LazyLoad(Laziness.False);

        }
    }
}
