using AutoMapper;
using Business.Abstract;
using Business.Schema.Category;
using Business.Validators;
using DataAccess.Repository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ICategoryValidator categoryValidator;
        private IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, ICategoryValidator categoryValidator, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.categoryValidator = categoryValidator;
            _mapper = mapper;
        }

        public void AddCategory(CategoryRequest categoryRequest)
        {
            var category = _mapper.Map<Category>(categoryRequest);
            
            var validationResult = categoryValidator.Validate(category);
            if (validationResult.IsValid)
            {
                categoryRepository.Add(category);
            }
            
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }

        public Category GetCategory(CategoryRequest request)
        {
            var category = categoryRepository.Get(x => x.Title == request.Title);
            return category;
        }
    }
}
