using NHibernate;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    [Serializable]
    public class AuditInterceptor : EmptyInterceptor {

        public override bool OnFlushDirty(object entity,
                                          object id,
                          object[] currentState,
                          object[] previousState,
                          string[] propertyNames,
                          IType[] types)
        {
            if (entity is IAuditable)
            {
                for (int i = 0; i < propertyNames.Length; i++)
                {
                    if ("DateModified".Equals(propertyNames[i]))
                    {
                        currentState[i] = DateTime.Now;
                        return true;
                    }
                }
            }
            return false;
        }

        public override bool OnSave(object entity,
                                    object id,
                    object[] state,
                    string[] propertyNames,
                    IType[] types)
        {
            if (entity is IAuditable)
            {
                for (int i = 0; i < propertyNames.Length; i++)
                {
                    if ("DateOfCreation".Equals(propertyNames[i]))
                    {
                        state[i] = DateTime.Now;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
