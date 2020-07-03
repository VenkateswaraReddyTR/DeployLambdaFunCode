using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class SchemaTypeService : BaseService, ISchemaTypeService
    {
        public SchemaTypeService(IRepository repository)
            : base(repository)
        {
        }
       
        public virtual EfileSchemaType GetSchemaType(string name)
        {
            return _repository.GetAll<EfileSchemaType>().Where(x => x.Name == name).SingleOrDefault();
        }
    }
}
