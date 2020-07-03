using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace TRTA.Diagnostics.Domain.Database
{
    public interface ISessionManager
    {
        ISession Session { get; }
        ITransaction Transaction { get; }
        void Rollback();
        void Commit();
    }
}
