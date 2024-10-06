using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Model;
using NLayerApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {
            return await _context.Categories.Include(p => p.Products).Where(p=>p.Id==categoryId).SingleOrDefaultAsync();
        }
    }
}
