using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class TaxAppYearMap : ClassMap<TaxAppYear>
    {
        public TaxAppYearMap()
        {
            //Schema("brms");
            Table("TaxAppYear");

            Id(x => x.Id).Column("Id");
            Map(x => x.Year).Column("\"Year\""); ;
        }
    }
}
