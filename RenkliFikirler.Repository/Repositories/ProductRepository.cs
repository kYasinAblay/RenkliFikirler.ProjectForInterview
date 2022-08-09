using Microsoft.EntityFrameworkCore;
using RenkliFikirler.Core.Models;
using RenkliFikirler.Core.Repositories;

namespace RenkliFikirler.Repository.Repositories;

public class ProductRepository:GenericRepository<Product>,IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Product>> GetProductsWithCategoryAsync()
    {
        return await _context.Products.Include(d => d.Category).ToListAsync();
    }
}