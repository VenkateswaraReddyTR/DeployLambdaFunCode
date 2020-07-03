using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class RuleService : BaseService, IRuleService
    {
        public RuleService(IRepository repository)
            : base(repository)
        {
        }
        public async Task<IEnumerable<Domain.Rule>> GetSpecificRulesAsync(string year, string returnType, string jurisdiction, string schemaType, bool isPublished, bool isActive, bool isDeleted, bool hasLogic, int limit)
        {
            string query = "select rule from TRTA.Diagnostics.Domain.Rule as rule " +
                           " join rule.TaxAppYear as ty " +
                           " join rule.ReturnType as rt " +
                           " join rule.Jurisdiction as j " +
                           " join rule.SchemaType as st " +
                           " left join rule.SecondaryReturnTypes as srt " +
                           " left join rule.SecondaryJurisdictions as sj " +
                           " where ty.Year = cast(:TaxAppYear as String) " +
                           " and (rt.Name = cast(:ReturnType as String) or srt.Name = cast(:ReturnType as String)) " +
                           " and (j.Name = :Jurisdiction or sj.Name = :Jurisdiction) " +
                           " and st.Name = :SchemaType " +
                           " and rule.IsPublished = : IsPublished" +
                           " and rule.IsActive = : IsActive" +
                           " and rule.IsDeleted = : IsDeleted";
            if (hasLogic) query += " and (rule.Logic is not null or rule.Logic != '')";
            IDictionary<string, object> parametersForQuery = new Dictionary<string, object>();
            parametersForQuery.Add("TaxAppYear", year);
            parametersForQuery.Add("ReturnType", returnType); 
            parametersForQuery.Add("Jurisdiction", $"'{jurisdiction}'");
            parametersForQuery.Add("SchemaType", $"'{schemaType}'");
            parametersForQuery.Add("IsPublished", isPublished);
            parametersForQuery.Add("IsActive", isActive);
            parametersForQuery.Add("IsDeleted", isDeleted);
            
            return _repository.ExecuteHQLQuery<Domain.Rule>(query, parametersMap: parametersForQuery, limit: limit);

        }
        public async Task<bool> CheckRulesExistAsync(string year, string returnType, string jurisdiction, string schemaType, bool isPublished, bool isActive, bool isDeleted, bool hasLogic)
        {
            return (await GetSpecificRulesAsync(year, returnType, jurisdiction, schemaType, isPublished, isActive, isDeleted, hasLogic, 1)).Any();
        }
    }
}
