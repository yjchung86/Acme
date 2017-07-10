using ProductServices.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServices.Persistence.EntityTypeConfigurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.ProductCode)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.ProductName)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Category)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.ImageUrl)
                .HasMaxLength(255);

            HasMany(p => p.Tags)
                .WithOptional();
        }
    }
}
