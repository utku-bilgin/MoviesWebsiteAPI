using AutoMapper;
using Entities;
using Models.DTOs.Movies;

namespace BLL.Concrete.Mapper.Movies
{
    public class MovieProfil : Profile
    {
        public MovieProfil()
        {
            CreateMap<MovieDTO, Movie>().ReverseMap();
        }
    }
}
