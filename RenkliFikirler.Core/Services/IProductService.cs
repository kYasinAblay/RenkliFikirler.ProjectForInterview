using RenkliFikirler.Core.DTOs;
using RenkliFikirler.Core.Models;

namespace RenkliFikirler.Core.Services;

public interface IProductService:IService<Product>
{
    Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategoryAsync();
}