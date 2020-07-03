using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class RuleExecutionLogMap  : ClassMap<RuleExecutionLog>
    {
        public RuleExecutionLogMap()
        {
            //Schema("brms");
            Table("[RuleExecutionLog]");

            Id(x => x.Id).Column("Id").GeneratedBy.Assigned();
            References(x => x.Locator).Column("LocatorId").LazyLoad(Laziness.False);
            Map(x => x.StartTime).CustomType("datetime2");
            Map(x => x.Endtime).CustomType("datetime2").Nullable();
            Map(x => x.Status);
            References(x => x.SchemaType).Column("SchemaTypeId").LazyLoad(Laziness.False); 
            Map(x => x.DiagnosticInfo).CustomType("StringClob").CustomSqlType("nvarchar(max)");
            References(x => x.EvaluationRequest).Column("EvaluationRequestId").LazyLoad(Laziness.False);  
                  
        }
    }
}
