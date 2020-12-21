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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
