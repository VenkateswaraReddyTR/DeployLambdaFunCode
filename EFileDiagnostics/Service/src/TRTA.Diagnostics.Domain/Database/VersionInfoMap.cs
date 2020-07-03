using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Domain.Database
{
    class VersionInfoMap : ClassMap<VersionInfo>
    {
        public VersionInfoMap()
        {
            //Schema("brms");
            Table("VersionInfo");

            Id(x => x.Version).Column("Version");
            Map(x => x.AppliedOn);
            Map(x => x.Description);
        }
    }
}
