using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class MetaDataVersionMap : ClassMap<MetaDataVersion>
    {
        public MetaDataVersionMap()
        {
            //Schema("brms");
            Table("[MetaDataVersion]");

            Id(x => x.Id).Column("Id");
            Map(x => x.FileInfoId);
            References(x => x.TaxAppYear).Column("TaxAppYearId").LazyLoad(Laziness.False);
            References(x => x.ReturnType).Column("ReturnTypeId").LazyLoad(Laziness.False);
            References(x => x.Jurisdiction).Column("JurisdictionId").LazyLoad(Laziness.False);
            References(x => x.SchemaType).Column("SchemaTypeId").LazyLoad(Laziness.False);
            Map(x => x.DateModified);
        }
    }
}
