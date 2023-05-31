using AutoMapper;
using Business.Schema.Category;
using Business.Schema.Product;
using Entities.Concrete;

namespace API.Utilities
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<CategoryRequest, Category>();
            CreateMap<ProductRequest, Product>();
        }
    }
}
