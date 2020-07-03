using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRTA.Diagnostics.Domain.Database;

namespace TRTA.Diagnostics.Repository
{
    public class BaseService
    {
        public IRepository _repository;
        public BaseService(IRepository repository)
        {
            _repository = repository;
        }
    }
}