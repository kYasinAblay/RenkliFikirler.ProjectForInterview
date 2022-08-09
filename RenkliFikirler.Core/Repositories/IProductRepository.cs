using RenkliFikirler.Core.Models;

namespace RenkliFikirler.Core.Repositories;

public interface IProductRepository:IGenericRepository<Product>
{
    Task<List<Product>> GetProductsWithCategoryAsync();
}