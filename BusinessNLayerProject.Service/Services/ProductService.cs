using BusinessNLayerProject.Core.Models;
using BusinessNLayerProject.Core.Repositories;
using BusinessNLayerProject.Core.Services;
using BusinessNLayerProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessNLayerProject.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
