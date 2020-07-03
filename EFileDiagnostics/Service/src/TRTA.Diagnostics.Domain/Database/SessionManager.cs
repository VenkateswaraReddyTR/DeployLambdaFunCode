using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Automapping;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using NHibernate.Caches.CoreMemoryCache;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace TRTA.Diagnostics.Domain.Database
{
    public class SessionManager : ISessionManager, IDisposable
    {
        private static ISessionFactory _sessionFactory;
        private static object sessionFactoryLock = new object();
        public ISession _currentSession;
        private static IConfiguration _configuration;

        public ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory;
            }
        }

        public ISession Session
        {
            get
            {
                return _currentSession ?? (_currentSession = _sessionFactory.OpenSession());
            }
        }
        public ITransaction Transaction
        {
            get
            {
                return Session.BeginTransaction();
            }
        }


        public SessionManager(IConfiguration configuration)
        {
            _configuration = configuration;
            GetSessionFactory();
        }

        public static ISessionFactory GetSessionFactory()
        {
            if (null == _sessionFactory)
            {
                lock (sessionFactoryLock)
                {
                    if (null == _sessionFactory)
                    { 
                        string connectstring = _configuration.GetConnectionString("PostgreConnectionString");
                         
                        _sessionFactory = Fluently.Configure()
                                .Database(
                            PostgreSQLConfiguration.PostgreSQL82.ConnectionString(connectstring)
                                
                            )
                                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Country>())
                                .ExposeConfiguration(cfg =>
                                {
                                    cfg.EventListeners.PreInsertEventListeners =
                                        new NHibernate.Event.IPreInsertEventListener[] { new AuditEventListener() };
                                    cfg.EventListeners.PreUpdateEventListeners =
                                        new NHibernate.Event.IPreUpdateEventListener[] { new AuditEventListener() };
                                })
                            //Configuring the SysCacheProvider as the second level cache provider
                                .Cache(c => c.ProviderClass<CoreMemoryCacheProvider>().UseSecondLevelCache().UseQueryCache())

                                .BuildSessionFactory();
                    }
                    //Session.FlushMode = FlushMode.Auto; 
                }
            }
            return _sessionFactory; 
        }
        public void Dispose()
        {
            Rollback();
            if (Session != null)
                Session.Close();
            if (_sessionFactory != null)
                _sessionFactory.Dispose();
        }
        public void Rollback()
        {
            if (Transaction.IsActive)
                Transaction.Rollback();
        }

        public void Commit()
        {
            if (Transaction.IsActive)
                Transaction.Commit();
        }
        

    }
}
