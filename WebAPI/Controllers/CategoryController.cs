using AutoMapper;
using BLL.Abstract.IServices;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Categories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }


        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllCategoriesNonDeleted();
            return Ok(categories);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var category = await _categoryService.GetCategoryByGuid(id);
            return Ok(category);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Post(CategoryAddDTO categoryAddDTO)
        {
            if (categoryAddDTO == null)
            {
                return BadRequest("Kategori verisi boş olamaz.");
            }

            await _categoryService.CreateCategoryAsync(categoryAddDTO);

            if (categoryAddDTO == null)
            {
                return BadRequest("Kategori oluşturma başarısız.");
            }

            return CreatedAtAction(nameof(Get), categoryAddDTO);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, CategoryUpdateDTO categoryUpdateDTO)
        {
            if (id != categoryUpdateDTO.Id)
            {
                return BadRequest("İstek gövdesindeki ID ile URI'deki ID uyuşmuyor.");
            }

            await _categoryService.UpdateCategoryAsync(categoryUpdateDTO);

            return Ok(categoryUpdateDTO);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var isDeleted = await _categoryService.DeleteCategoryAsync(id);

            if (isDeleted)
            {
                return Ok("Kategori başarıyla silindi.");
            }
            else
            {
                return NotFound("Belirtilen ID ile kategori bulunamadı veya silme işlemi başarısız.");
            }
        }
    }
}
