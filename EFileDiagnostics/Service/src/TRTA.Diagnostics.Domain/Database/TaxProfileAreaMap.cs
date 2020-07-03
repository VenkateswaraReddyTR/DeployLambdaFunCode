using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class TaxProfileAreaMap : ClassMap<TaxProfileArea>
    {
        public TaxProfileAreaMap()
        {
            //Schema("brms");
            Table("[TaxProfileArea]");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name);
        }
    }
}
