using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using System.Reflection;
using NHibernate.Transform;
using System.Collections;

namespace TRTA.Diagnostics.Domain.Database
{
    public class Repository : IRepository
    {
        public readonly ISessionManager _sessionManager;
        private readonly ITransaction _transaction;
        private static Dictionary<Type, Guid> _syncIds = new Dictionary<Type, Guid>();

        public Repository(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
            _transaction = _sessionManager.Transaction;            
        }
        private void Changing<T>(List<T> entities) where T : class
        {
            Changing<T>();
        }

        private void Changing<T>(T entity) where T : class
        {
            Changing<T>();
        }

        private void Changing<T>() where T : class
        {
            lock (_syncIds)
            {
                _syncIds[typeof(T)] = Guid.NewGuid();
            }
        }

        public void Insert<T>(T entity) where T : class
        {
            try
            {
                Changing(entity);               
                _sessionManager.Session.Save(entity);
                _sessionManager.Commit();
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }

        public void Merge<T>(T entity) where T : class
        {
            try
            {
                Changing(entity);
                _sessionManager.Session.Merge(entity);
                _sessionManager.Commit();
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }

        public void Save<T>(T entity) where T : class
        {
            try
            {
                Changing(entity);                
                _sessionManager.Session.SaveOrUpdate(entity);
                _sessionManager.Commit();
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }

        }

        public void SaveAll<T>(List<T> entities) where T : class
        {
            try
            {
                foreach (T item in entities) 
                    _sessionManager.Session.SaveOrUpdate(item);
                _sessionManager.Commit();
            }
            catch(Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }

        public void UpdateField<T>(string field, object newValue, object id) where T : class
        {
            try
            {
                Changing<T>();
                T t = _sessionManager.Session.Get<T>(id);
                if (t != null)
                {
                    Type type = t.GetType();
                    PropertyInfo prop = type.GetProperty(field);
                    prop.SetValue(t, newValue, null);
                    _sessionManager.Session.SaveOrUpdate(t);
                    _sessionManager.Commit();
                }
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }

        public T Get<T>(object id) where T : class
        {
            return _sessionManager.Session.Get<T>(id);
        }

        public IQueryable<T> GetAll<T>() where T : class, new()
        {
            return _sessionManager.Session.Query<T>();
        }
        public void Load<T>(IEnumerable<T> entities) where T : class
        {
            NHibernateUtil.Initialize(entities);
        }

        public void Load<T>(T entity) where T : class
        {
            NHibernateUtil.Initialize(entity);
        }
        public void Delete<T>(object id) where T : class, new()
        {
            try
            {
                Changing<T>();
                T t = _sessionManager.Session.Get<T>(id);
                if (t != null)
                {
                    _sessionManager.Session.Delete(t);
                    _sessionManager.Commit();
                }
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }

        }
        public void DeleteAll<T>(List<T> entities) where T : class
        {
            try
            {                
                foreach (T item in entities) 
                    _sessionManager.Session.Delete(item);
                _sessionManager.Commit();
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }
        #region "Code need to be removed once we identify change"
        //public void DeleteAll<T>(string whereClause) where T : class, new()
        //{
        //    Changing<T>();
        //    var q = _sessionManager.Session.CreateSQLQuery(string.Format("DELETE FROM {0} WHERE {1}", typeof(T).Name, whereClause));
        //    q.ExecuteUpdate();
        //}

        //public void DeleteAll(string tableName, string whereClause)
        //{
        //    var q = _sessionManager.Session.CreateSQLQuery(string.Format("DELETE FROM {0} WHERE {1}", tableName, whereClause));
        //    q.ExecuteUpdate();

        //}
        #endregion
        public Dictionary<TParentKey, List<TChildKey>> QueryRelation<TParent, TParentKey, TChild, TChildKey>()
        {
            string sql = string.Format("SELECT {0}_id, {1}_id FROM {0}To{1}", typeof(TParent).Name, typeof(TChild).Name);

            return ExecuteRelationQuery<TParent, TParentKey, TChild, TChildKey>(sql);
        }

        public Dictionary<TParentKey, List<TChildKey>> QueryRelation<TParent, TParentKey, TChild, TChildKey>(string parentColName, string childColName)
        {
            string sql = string.Format("SELECT {0}, {1} FROM {2}To{3}", parentColName, childColName, typeof(TParent).Name, typeof(TChild).Name);

            return ExecuteRelationQuery<TParent, TParentKey, TChild, TChildKey>(sql);
        }

        private Dictionary<TParentKey, List<TChildKey>> ExecuteRelationQuery<TParent, TParentKey, TChild, TChildKey>(string sql)
        {
            var q = _sessionManager.Session.CreateSQLQuery(sql);
            var result = new Dictionary<TParentKey, List<TChildKey>>();
            var list = q.List();
            foreach (var item in list)
            {
                var parentKey = (TParentKey)((item as object[])[0]);
                if (!result.ContainsKey(parentKey)) result[parentKey] = new List<TChildKey>();
                result[parentKey].Add((TChildKey)((item as object[])[1]));
            }
            return result;
        }

        public void DeleteAll<T>(IEnumerable<int> ids) where T : class, new()
        {
            Changing<T>();

            foreach (int id in ids) Delete<T>(id);
        }

        public void DeleteAll<T>(IEnumerable<Guid> ids) where T : class, new()
        {
            Changing<T>();
            try
            {  
                foreach (var id in ids)
                {
                    T t = _sessionManager.Session.Get<T>(id);
                    if (t != null)
                    {
                        _sessionManager.Session.Delete(t);
                    }
                }
                _sessionManager.Commit();
            }
            catch (Exception ex)
            {
                _sessionManager.Rollback();
                throw ex;
            }
        }

        public void Refresh<T>(T entity) where T : class, new()
        {
            Changing(entity);
            _sessionManager.Session.Refresh(entity);
        }
        public static Guid SyncId(Type t)
        {
            lock (_syncIds)
            {
                if (!_syncIds.ContainsKey(t))
                    _syncIds[t] = Guid.NewGuid();

                return _syncIds[t];
            }
        }

        public void Dispose()
        {
        }

        public IEnumerable<T> ExecuteHQLQuery<T>(string query, IDictionary<string, object> parametersMap = null, IDictionary<string, IEnumerable> parametersListMap = null, int limit = -1) where T : class, new()
        {
            IQuery q = _sessionManager.Session.CreateQuery(query);
            if (parametersMap != null)
            {
                foreach (var parameterName in parametersMap.Keys)
                    q.SetParameter(parameterName, parametersMap[parameterName]);
            }
            if (parametersListMap != null)
            {
                foreach (var parameterName in parametersListMap.Keys)
                    q.SetParameterList(parameterName, parametersListMap[parameterName]);
            }
            if (limit > 0)
                q.SetMaxResults(limit);
            return q.SetCacheable(true).SetCacheMode(CacheMode.Normal).List<T>();
        }

        public IEnumerable<T> ExecuteStoredProcedure<T>(string query, IDictionary<string, object> parametersMap, int limit = -1) where T : class, new()
        {
            IQuery q = _sessionManager.Session.CreateSQLQuery(query);
            foreach (var parameterName in parametersMap.Keys)
                q.SetParameter(parameterName, parametersMap[parameterName]);
            if (limit > 0)
                q.SetMaxResults(limit);
            q.SetResultTransformer(Transformers.AliasToBean<T>());

            return q.List<T>();
        }
    }
}
