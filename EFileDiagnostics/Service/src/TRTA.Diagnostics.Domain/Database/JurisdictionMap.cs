using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class JurisdictionMap : ClassMap<Jurisdiction>
    {
        public JurisdictionMap()
        {
            //Schema("brms");
            Table("Jurisdiction");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("\"Name\"");
            Map(x => x.ShortName);
            References<Country>(x => x.Country).Column("CountryId").LazyLoad(Laziness.False);
            References<JurisdictionType>(x => x.JurisdictionType).Column("JurisdictionTypeId").LazyLoad(Laziness.False);
        }
    }
}
