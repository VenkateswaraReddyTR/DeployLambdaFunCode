using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;


namespace TRTA.Diagnostics.Domain.Database
{
    public class CountryMap : ClassMap<Country>
    {
        public CountryMap()
        {
            //Schema("brms");
            Table("Country");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name);

        }

    }
}
