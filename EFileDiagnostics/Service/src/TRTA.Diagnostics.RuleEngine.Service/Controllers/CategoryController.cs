using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRTA.Diagnostics.Domain;
using TRTA.Diagnostics.Repository;

namespace TRTA.Diagnostics.RuleEngine.Service.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            IEnumerable<Category> data = _categoryService.GetAll();
            return Ok(data);
        }
    }
}