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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = _ids[0], Name = "Sebze" },
                new Category { Id = _ids[1], Name = "Ev malzemeleri" },
                new Category { Id = _ids[2], Name = "Kırtasiye" }
                );
        }
    }
}
