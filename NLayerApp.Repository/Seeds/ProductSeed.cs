using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id=1,Name="İphone",CategoryId=1,Price=700,Stock=50,CreatedDate=DateTime.Now},
                new Product { Id=2,Name="Macbook",CategoryId=2,Price=1200,Stock=50,CreatedDate=DateTime.Now},
                new Product { Id=3,Name="Dell",CategoryId=2,Price=650,Stock=50,CreatedDate=DateTime.Now},
                new Product { Id=4,Name="Canon",CategoryId=3,Price=650,Stock=50,CreatedDate=DateTime.Now}
                );
        }
    }
}
