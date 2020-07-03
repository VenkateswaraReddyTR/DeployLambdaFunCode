using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    public class LocatorMap : ClassMap<Locator>
    {
        public LocatorMap()
        {
            Table("\"Locator\"");
            Id(x => x.Id);
            Map(x => x.ReturnType);
            Map(x => x.TaxAppYear);           
            Map(x => x.Name);
            Map(x => x.Jurisdiction);
        }
    }
}
