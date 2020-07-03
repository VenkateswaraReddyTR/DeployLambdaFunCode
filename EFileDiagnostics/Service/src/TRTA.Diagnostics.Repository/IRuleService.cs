using System.Threading.Tasks;

namespace TRTA.Diagnostics.Repository
{
    public interface IRuleService
    {
        Task<bool> CheckRulesExistAsync(string year, string returnType, string jurisdiction, string schemaType, bool isPublished, bool isActive, bool isDeleted, bool hasLogic);
    }
}