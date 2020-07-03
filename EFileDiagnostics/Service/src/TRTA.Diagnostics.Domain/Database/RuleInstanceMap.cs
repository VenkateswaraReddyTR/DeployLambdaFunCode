using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class RuleInstanceMap:ClassMap<RuleInstance>
    {
        public RuleInstanceMap()
        {
            //Schema("brms");
            Table("[RuleServiceInstance]");

            Id(x => x.Id).Column("Id");
            Map(x => x.InstanceName);
            Map(x => x.Active);
            Map(x => x.QueueSize);
        }
    }
}
