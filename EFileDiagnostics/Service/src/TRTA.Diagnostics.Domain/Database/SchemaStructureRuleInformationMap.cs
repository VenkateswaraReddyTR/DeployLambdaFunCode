using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    public class SchemaStructureRuleInformationMap : ClassMap<SchemaStructureRuleInformation>
    {
        public SchemaStructureRuleInformationMap()
        {
            //Schema("brms");
            Table("[SchemaStructureRuleMapping]");

            Id(x => x.Id);
            Map(x => x.ReturnType);
            Map(x => x.RulesInvolved);
            Map(x => x.SchemaStructureSet);
        }
    }
}
