using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjetct.Core.Models;
using UdemyNLayerProjetct.Core.Repository;

namespace UdemyNLayerProjetct.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext appContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext appContext):base(appContext)
        {

        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appContext.Categories.Include(m => m.Products)
                  .FirstOrDefaultAsync(m => m.Id == categoryId);
        }
    }
}
