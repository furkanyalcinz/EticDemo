using Business.Schema.Product;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        public void Add(ProductRequest request);
        public List<Product> GetAll();
    }
}
