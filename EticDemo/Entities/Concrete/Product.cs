using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public uint Unit { get; set; }
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Title).IsRequired();
        }
    }
}
