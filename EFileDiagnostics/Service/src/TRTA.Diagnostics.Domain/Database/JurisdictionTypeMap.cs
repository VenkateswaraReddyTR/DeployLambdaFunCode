using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;


namespace TRTA.Diagnostics.Domain.Database
{
    public class JurisdictionTypeMap : ClassMap<JurisdictionType>
    {
        public JurisdictionTypeMap()
        {
            //Schema("brms");
            Table("JurisdictionType");

            Id(x => x.Id).Column("Id").GeneratedBy.Assigned();
            Map(x => x.Name);

        }

    }

}
