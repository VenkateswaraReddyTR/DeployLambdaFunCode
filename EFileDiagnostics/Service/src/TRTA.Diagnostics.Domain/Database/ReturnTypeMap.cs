using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class ReturnTypeMap : ClassMap<ReturnType>
    {
        public ReturnTypeMap()
        {
            //Schema("brms");
            Table("ReturnType");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name).Column("\"Name\"");
            HasManyToMany(x => x.Jurisdictions).Table("ReturnTypeToJurisdiction").ParentKeyColumn("ReturnTypeId").ChildKeyColumn("JurisdictionId").Cascade.SaveUpdate();
        }
    }
}
