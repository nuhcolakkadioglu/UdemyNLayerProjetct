using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjetct.Core.Models;

namespace UdemyNLayerProjetct.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "kiraz", Price = 2.50m, Stock = 100, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "beyaz çamaşır tozu", Price = 65, Stock = 15, CategoryId = _ids[1] },
                new Product { Id = 3, Name = "çilek", Price = 3.50m, Stock = 250, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "cay bardagı", Price = 15, Stock = 6, CategoryId = _ids[1] },
                new Product { Id = 5, Name = "defter", Price = 7.50m, Stock = 15, CategoryId = _ids[2] },
                new Product { Id = 6, Name = "kalem", Price = 5, Stock = 20, CategoryId = _ids[2] }
                );
        }
    }
}
