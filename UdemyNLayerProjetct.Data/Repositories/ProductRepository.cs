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
    public class ProductRepository : Repository<Product>,IProductRepository
    {

        
        private AppDbContext appContext { get => _context as AppDbContext; }
        public ProductRepository(AppDbContext appDbContext):base(appDbContext)
        {

        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {

            
            return await appContext.Products.Include(m => m.Category)
                 .FirstOrDefaultAsync(m => m.Id == productId);
         
        }
    }
}
