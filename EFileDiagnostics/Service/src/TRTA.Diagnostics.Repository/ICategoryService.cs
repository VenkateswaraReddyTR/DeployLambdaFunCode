using System;
using System.Collections.Generic;
using System.Text;
using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Repository
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category Get(Guid Id);
        void Save(Category Category);
    }
}
