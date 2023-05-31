using Business.Schema.Category;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public void AddCategory(CategoryRequest categoryRequest);
        public Category GetCategory(CategoryRequest request);
        public List<Category> GetAllCategories();
    }
}
