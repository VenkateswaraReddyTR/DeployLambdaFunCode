using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;


namespace TRTA.Diagnostics.Domain.Database
{
    class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            //Schema("brms");
            Table("Category");

            Id(x => x.Id).Column("Id");
            Map(x => x.Name);
            //HasManyToMany(x => x.Rules).Table("RuleToCategory").ParentKeyColumn("CategoryId").ChildKeyColumn("RuleId").Cascade.SaveUpdate().Inverse();
            //HasManyToMany(x => x.PurgeRules).Table("PurgeRuleToCategory").ParentKeyColumn("CategoryId").ChildKeyColumn("PurgeRuleId").Cascade.SaveUpdate().Inverse();
        }
    }
}
