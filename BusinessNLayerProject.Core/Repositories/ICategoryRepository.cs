using BusinessNLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessNLayerProject.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
