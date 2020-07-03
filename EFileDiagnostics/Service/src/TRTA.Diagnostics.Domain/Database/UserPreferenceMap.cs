using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class UserPreferenceMap : ClassMap<UserPreference>
    {
        public UserPreferenceMap()
        {
            //Schema("brms");
            Table("UserPreference");

            Id(x => x.UserId).Column("UserId");
            Map(x => x.PreferenceJson);
        }
    }
}
