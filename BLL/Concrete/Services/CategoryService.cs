using AutoMapper;
using BLL.Abstract.IServices;
using DAL.UnitOfWorks;
using Entities;
using Models.DTOs.Categories;

namespace BLL.Concrete.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CategoryDTO>> GetAllCategoriesNonDeleted()
        {
            var categories = await _unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            var map = _mapper.Map<List<CategoryDTO>>(categories);
            return map;
        }

        public async Task<Category> GetCategoryByGuid(Guid id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByGuidAsync(id);
            return category;
        }

        public async Task CreateCategoryAsync(CategoryAddDTO categoryAddDTO)
        {
            Category category = new(categoryAddDTO.Name);
            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            await _unitOfWork.SaveAsync();
        }

        public async Task<string> UpdateCategoryAsync(CategoryUpdateDTO categoryUpdateDTO)
        {

            var category = await _unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdateDTO.Id);
            category.Name = categoryUpdateDTO.Name;
            category.ModifiedDate = DateTime.Now;

            await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await _unitOfWork.SaveAsync();

            return category.Name;
        }

        public async Task<bool> DeleteCategoryAsync(Guid categoryId)
        {
            // Veritabanından kategoriyi al
            var category = await _unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);

            if (category == null)
            {
                return false;
            }

            _unitOfWork.GetRepository<Category>().Delete(category);
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
