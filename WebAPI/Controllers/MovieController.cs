using AutoMapper;
using BLL.Abstract.IServices;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Movies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MovieController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _movieService.GetAllMovieWithCategoryNonDeletedAsync();
            return Ok(movies);
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var movie = await _movieService.GetMovieWithCategoryNonDeletedAsync(id);
            return Ok(movie);
        }

        // POST api/<MovieController>
        [HttpPost]
        public async Task<IActionResult> Post(MovieAddDTO movieAddDTO)
        {
            if (movieAddDTO == null)
            {
                return BadRequest("Film verisi boş olamaz.");
            }

            // Film oluşturma işlemini yapın
            await _movieService.CreateMovieAsync(movieAddDTO);

            // Film oluşturulduysa başarılı bir yanıt gönderin
            return CreatedAtAction(nameof(Get), movieAddDTO);
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, MovieUpdateDTO movieUpdateDTO)
        {
            if (id != movieUpdateDTO.Id)
            {
                return BadRequest("İstek gövdesindeki ID ile URI'deki ID uyuşmuyor.");
            }

            await _movieService.UpdateMovieAsync(movieUpdateDTO);

            return Ok(movieUpdateDTO);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var isDeleted = await _movieService.DeleteMovieAsync(id);

            if (isDeleted)
            {
                return Ok("Film başarıyla silindi.");
            }
            else
            {
                return NotFound("Belirtilen ID ile film bulunamadı veya silme işlemi başarısız.");
            }
        }
    }
}
