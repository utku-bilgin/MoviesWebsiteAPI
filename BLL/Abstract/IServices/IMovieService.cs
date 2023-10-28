using Entities;
using Models.DTOs.Movies;

namespace BLL.Abstract.IServices
{
    public interface IMovieService
    {
        Task<List<MovieDTO>> GetAllMovieWithCategoryNonDeletedAsync();
        Task<Movie> GetMovieWithCategoryNonDeletedAsync(Guid id);
        Task CreateMovieAsync(MovieAddDTO movieAddDTO);
        Task<Movie> UpdateMovieAsync(MovieUpdateDTO movieUpdateDTO);
        Task<bool> DeleteMovieAsync(Guid movieId);
    }
}
