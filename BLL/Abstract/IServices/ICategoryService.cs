using Entities;
using Models.DTOs.Categories;

namespace BLL.Abstract.IServices
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategoriesNonDeleted();
        Task<Category> GetCategoryByGuid(Guid id);
        Task CreateCategoryAsync(CategoryAddDTO categoryAddDTO);
        Task<string> UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDTO);
        public Task<bool> DeleteCategoryAsync(Guid categoryId);
    }
}
