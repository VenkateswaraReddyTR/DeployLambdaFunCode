using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRTA.Diagnostics.Domain.Database
{
    public interface IRepository : IDisposable
    {
        void Insert<T>(T entity) where T : class;
        void Merge<T>(T entity) where T : class;
        void Save<T>(T entity) where T : class;
        void SaveAll<T>(List<T> entity) where T : class;
        void UpdateField<T>(string field, object newValue, object id) where T : class;
        T Get<T>(object id) where T : class;
        IQueryable<T> GetAll<T>() where T : class, new();
        void Delete<T>(object id) where T : class, new();
        void DeleteAll<T>(IEnumerable<int> ids) where T : class, new();
        #region "Code need to be removed once we identify change"
        //void DeleteAll<T>(string whereClause) where T : class, new();
        //void DeleteAll(string table, string whereClause);
        #endregion
        void Refresh<T>(T entity) where T : class, new();
        void Load<T>(IEnumerable<T> entities) where T : class;
        void Load<T>(T entity) where T : class;
        Dictionary<TParentKey, List<TChildKey>> QueryRelation<TParent, TParentKey, TChild, TChildKey>();
        Dictionary<TParentKey, List<TChildKey>> QueryRelation<TParent, TParentKey, TChild, TChildKey>(string parentColName, string childColName);
        void DeleteAll<T>(List<T> entity) where T : class;
        IEnumerable<T> ExecuteHQLQuery<T>(string query, IDictionary<string, object> parametersMap = null, IDictionary<string, IEnumerable> parametersListMap = null, int limit = -1) where T : class, new();
        IEnumerable<T> ExecuteStoredProcedure<T>(string query, IDictionary<string, object> parametersMap, int limit = -1) where T : class, new();
    }
}
