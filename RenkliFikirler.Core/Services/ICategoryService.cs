using RenkliFikirler.Core.DTOs;
using RenkliFikirler.Core.Models;

namespace RenkliFikirler.Core.Services;

public interface ICategoryService:IService<Category>
{
    public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdProductsAsync(int categoryId);
}