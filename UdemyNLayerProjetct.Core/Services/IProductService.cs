using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjetct.Core.Models;

namespace UdemyNLayerProjetct.Core.Services
{
    public interface IProductService : IService<Product>
    {
        // bool ControlInnerBarcode(Product product);
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
