using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    class EvaluationRequestMap : ClassMap<EvaluationRequest>
    {
        public EvaluationRequestMap()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.TaxAppYear);
            Map(x => x.ReturnType);
            Map(x => x.Jurisdiction);
            Map(x => x.Locator);
            Map(x => x.SchemaType);
            Map(x => x.DocumentToEvaluate).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            Map(x => x.RequestStatus);
            Map(x => x.DateOfCreation).CustomType("datetime2");
            Map(x => x.DateModified).CustomType("datetime2");  
            Map(x => x.InstanceName);
            Map(x => x.RequestedBy);
            Map(x => x.FileSize);
        }
    }
}
