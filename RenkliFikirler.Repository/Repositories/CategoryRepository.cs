using Microsoft.EntityFrameworkCore;
using RenkliFikirler.Core.Models;
using RenkliFikirler.Core.Repositories;

namespace RenkliFikirler.Repository.Repositories;

public class CategoryRepository:GenericRepository<Category>,ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Category> GetSingleCategoryByIdProductsAsync(int categoryId)
    {
        return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
    }
}