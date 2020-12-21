using BusinessNLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessNLayerProject.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);

        //bool ControlInnerbarcode(Product product);
    }
}
