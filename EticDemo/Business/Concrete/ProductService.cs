using AutoMapper;
using Business.Abstract;
using Business.Schema.Product;
using Business.Validators;
using DataAccess.Repository.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;
        private readonly IProductValidator _validator;

        public ProductService(IProductRepository productRepository, IMapper mapper, IProductValidator validator)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _validator = validator;
        }

        public void Add(ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            var validationResult = _validator.Validate(product);
            if (validationResult.IsValid)
            {
                _productRepository.Add(product);
            }
            
        }

        public List<Product> GetAll()
        {
            var result = _productRepository.GetAllIQueryalbe();
            
            var result_list = result.Include(x=>x.Category).ToList();
            return result_list;
        }
    }
}
