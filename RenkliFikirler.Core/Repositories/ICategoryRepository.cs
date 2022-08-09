using RenkliFikirler.Core.Models;

namespace RenkliFikirler.Core.Repositories;

public interface ICategoryRepository:IGenericRepository<Category>
{
    public Task<Category> GetSingleCategoryByIdProductsAsync(int categoryId);
}