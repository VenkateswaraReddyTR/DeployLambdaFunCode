using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class PrintDiagnosticMap : ClassMap<PrintDiagnostic>
    {
        public PrintDiagnosticMap()
        {
            //Schema("brms");
            Table("PrintDiagnostic");

            Id(x => x.Id).Column("Id");
            Map(x => x.StartTime);
            Map(x => x.EndTime);
            Map(x => x.Status);
            Map(x => x.FileUrl);
            Map(x => x.Locator);
            Map(x => x.TaxAppYear);
            Map(x => x.ReturnType);
            Map(x => x.Filter);
        }
    }
}
