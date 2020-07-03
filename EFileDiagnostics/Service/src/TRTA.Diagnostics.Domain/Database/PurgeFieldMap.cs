using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class PurgeFieldMap : ClassMap<PurgeField>
    {
        public PurgeFieldMap()
        {
            //Schema("brms");
            Table("[PurgeField]");

            Id(x => x.Id).Column("Id").GeneratedBy.Assigned();
            Map(x => x.Area);
            Map(x => x.Screen);
            Map(x => x.field);
            Map(x => x.typedesc);
            Map(x => x.Eorg);
            Map(x => x.name);
            Map(x => x.Annotation);
            Map(x => x.ReturnTypeId);
            Map(x => x.JurisdictionId);
            Map(x => x.SchemaTypeId);
            Map(x => x.Xpath);
            Map(x => x.MinOccurs);
            Map(x => x.MaxOccurs);
            Map(x => x.IsSimpleType);
            Map(x => x.IsElement);
            Map(x => x.FormName);
            Map(x => x.DateModified);
        }
    }
}
