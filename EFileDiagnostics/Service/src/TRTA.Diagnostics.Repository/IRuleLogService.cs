using System;
using System.Threading.Tasks;
using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Repository
{ 
    public interface IRuleLogService
    {
        Locator GetOrSaveLocator(string year, string jurisdiction, string returnType, string locator);
        Task SaveAsync(string taxAppYear, string jurisdiction, string returnType, Guid locatorId, EfileSchemaType efileSchemaType, int id, string DiagnosticInfo, string Id, string status);
    }
}