using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Schema.Product
{
    public class ProductRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public uint Unit { get; set; }
        public int CategoryId { get; set; }
    }
}
