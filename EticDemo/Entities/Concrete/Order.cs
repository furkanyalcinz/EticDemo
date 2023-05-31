using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int ProductId { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
