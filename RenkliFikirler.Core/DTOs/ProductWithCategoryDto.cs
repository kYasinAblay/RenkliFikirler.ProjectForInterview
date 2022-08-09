namespace RenkliFikirler.Core.DTOs;

public class ProductWithCategoryDto:ProductDto
{
    public CategoryDto Category { get; set; }
}