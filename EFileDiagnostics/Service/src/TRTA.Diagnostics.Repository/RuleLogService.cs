using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class RuleLogService : BaseService, IRuleLogService
    {
        private ILogger<RuleLogService> _logger;

        public RuleLogService(IRepository repository, ILogger<RuleLogService> logger)
               : base(repository)
        {
            _logger = logger;
        }
        public Locator GetOrSaveLocator(string year, string jurisdiction, string returnType, string locator)
        {
            Locator Locatordetails = null;
            try
            {
                Locatordetails = _repository.GetAll<Locator>().FirstOrDefault(l => l.TaxAppYear == year &&
                                                                                    l.ReturnType == returnType &&
                                                                                    l.Jurisdiction == jurisdiction &&
                                                                                    l.Name == locator);

                if (Locatordetails == null)
                {
                    Locatordetails = new Locator
                    {
                        TaxAppYear = year,
                        ReturnType = returnType,
                        Name = locator,
                        Jurisdiction = jurisdiction
                    };

                    _repository.Save(Locatordetails);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in locator GetOrSaveLocator");
            }

            return Locatordetails;
        }

        public async Task SaveAsync(string taxAppYear, string jurisdiction, string returnType, Guid locatorId, EfileSchemaType efileSchemaType, int id, string DiagnosticInfo, string Id, string status)
        {
            throw new NotImplementedException();
        }
    }
}
