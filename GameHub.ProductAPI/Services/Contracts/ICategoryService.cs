using GameHub.ProductAPI.DTOs;

namespace GameHub.ProductAPI.Services.Contracts;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategories();
    Task<IEnumerable<CategoryDTO>> GetCategoriesProducts();
    Task<CategoryDTO> GetCategoryById(int id);
    Task AddCategory(CategoryDTO categoryDto);
    Task UpdateCategory(CategoryDTO categoryDto);
    Task DeleteCategory(int id);
}
