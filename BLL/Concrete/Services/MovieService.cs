using AutoMapper;
using BLL.Abstract.IServices;
using DAL.UnitOfWorks;
using Entities;
using Models.DTOs.Movies;

namespace BLL.Concrete.Services
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MovieService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<MovieDTO>> GetAllMovieWithCategoryNonDeletedAsync()
        {
            var movies = await _unitOfWork.GetRepository<Movie>().GetAllAsync(x=>!x.IsDeleted);


            var map = _mapper.Map<List<MovieDTO>>(movies);
            return map;
        }

        public async Task<Movie> GetMovieWithCategoryNonDeletedAsync(Guid id)
        {
            var movie = await _unitOfWork.GetRepository<Movie>().GetByGuidAsync(id);
            return movie;
        }

        public async Task CreateMovieAsync(MovieAddDTO movieAddDTO)
        {
            // MovieAddDTO'dan Movie sınıfına veri aktarımını gerçekleştirin
            var movie = new Movie
            {
                Name = movieAddDTO.Name,
                MoviePosterUrl = movieAddDTO.MoviePosterUrl,
                MovieTrailerUrl = movieAddDTO.MovieTrailerUrl,
                MovieUrl = movieAddDTO.MovieUrl,
                Description = movieAddDTO.Description,
                ProductionYear = movieAddDTO.ProductionYear,
                MovieDuration = movieAddDTO.MovieDuration,
                Country = movieAddDTO.Country,
                Director = movieAddDTO.Director,
                Cast = movieAddDTO.Cast,
                ImdbRating = movieAddDTO.ImdbRating,
                CategoryId = movieAddDTO.CategoryId
            };

            await _unitOfWork.GetRepository<Movie>().AddAsync(movie);
            await _unitOfWork.SaveAsync();
        }

        public async Task<Movie> UpdateMovieAsync(MovieUpdateDTO movieUpdateDTO)
        {
            var movie = await _unitOfWork.GetRepository<Movie>().GetAsync(x => !x.IsDeleted && x.Id == movieUpdateDTO.Id);

            if (movie == null)
            {
                return null;
            }

            movie.Name = movieUpdateDTO.Name;
            movie.MoviePosterUrl = movieUpdateDTO.MoviePosterUrl;
            movie.MovieTrailerUrl = movieUpdateDTO.MovieTrailerUrl;
            movie.MovieUrl = movieUpdateDTO.MovieUrl;
            movie.Description = movieUpdateDTO.Description;
            movie.ProductionYear = movieUpdateDTO.ProductionYear;
            movie.MovieDuration = movieUpdateDTO.MovieDuration;
            movie.Country = movieUpdateDTO.Country;
            movie.Director = movieUpdateDTO.Director;
            movie.Cast = movieUpdateDTO.Cast;
            movie.ImdbRating = movieUpdateDTO.ImdbRating;
            movie.CategoryId = movieUpdateDTO.CategoryId;

            await _unitOfWork.GetRepository<Movie>().UpdateAsync(movie);
            await _unitOfWork.SaveAsync();

            return movie;
        }

        public async Task<bool> DeleteMovieAsync(Guid movieId)
        {
            var movie = await _unitOfWork.GetRepository<Movie>().GetByGuidAsync(movieId);

            if(movie == null)
            {
                return false;
            }

            _unitOfWork.GetRepository<Movie>().Delete(movie);
            await _unitOfWork.SaveAsync();

            return true;
        }
    }
}
