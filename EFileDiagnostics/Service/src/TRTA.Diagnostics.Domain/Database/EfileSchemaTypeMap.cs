using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class EfileSchemaTypeMap : ClassMap<EfileSchemaType>
    {
        public EfileSchemaTypeMap()
        {
            //Schema("brms");
            Table("SchemaType");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("\"Name\""); ;
        }
    }
}
