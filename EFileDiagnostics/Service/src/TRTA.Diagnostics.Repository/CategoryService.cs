using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Domain.Database;
using TRTA.Diagnostics.Repository;

namespace TRTA.Diagnostics.Repository
{
    public class CategoryService: BaseService, ICategoryService
    {
        public CategoryService(IRepository repository)
            : base(repository)
        {
        }
        public virtual IEnumerable<Category> GetAll()
        {
            return _repository.GetAll<Category>().OrderBy(x => x.Name);
        }

        public virtual Category Get(Guid Id)
        {
            return _repository.Get<Category>(Id);
        }
        public virtual void Save(Category Category)
        {
            _repository.Save(Category);
        }
    }
}