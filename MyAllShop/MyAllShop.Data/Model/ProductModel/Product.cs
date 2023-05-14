using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyAllShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyAllShop.Data.Model.ProductModel
{
    public class Product : EntityTypeConfiguration<Product>
    {
        public int Id { get; set; }
        public int Prise { get; set; }
        public string Name { get; set; }
        public CategoryEnum Category { get; set; }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TestProduct").Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.ToTable("TestProduct").Property(x => x.Prise).HasMaxLength(100).IsRequired();
        }


    }
}
