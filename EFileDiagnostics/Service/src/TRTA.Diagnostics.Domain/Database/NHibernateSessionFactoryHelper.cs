using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Caches.CoreMemoryCache;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    public static class NHibernateSessionFactoryHelper
    {
        public static ISessionFactory BuildSessionFactory()
        {
            var sessionFactory = Fluently.Configure()
                       .Database(
                           MsSqlConfiguration.MsSql2008.ConnectionString(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)
                       )
                       .CurrentSessionContext("web")
                       .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Country>())
                       .Cache(c => c.ProviderClass<CoreMemoryCacheProvider>().UseSecondLevelCache().UseQueryCache())
                       .BuildSessionFactory();

            return sessionFactory;
        }

        public static ISessionFactory BuildWindowsServiceSessionFactory()
        {
            var sessionFactory = Fluently.Configure()
                       .Database(
                           MsSqlConfiguration.MsSql2008.ConnectionString(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString)
                       )
                       .CurrentSessionContext("thread_static")
                       .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Country>())
                       .Cache(c => c.ProviderClass<CoreMemoryCacheProvider>().UseSecondLevelCache().UseQueryCache())
                       .BuildSessionFactory();

            return sessionFactory;
        }
    }
}
