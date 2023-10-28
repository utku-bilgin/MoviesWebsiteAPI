using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.Context.EntityTypeConfiguration
{
    public class MovieTypeConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasOne(m => m.Category)
                   .WithMany(c => c.Movies)
                   .HasForeignKey(m => m.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Movie
                {
                    Id = Guid.Parse("F6EC2A92-E085-4FBC-ABB4-A62038867165"),
                    Name = "The Shawshank Redemption",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg",
                    MovieTrailerUrl = "https://youtu.be/PLl99DlL6b4",
                    Description = "Andy Dufresne, haksız yere hüküm giydiği Shawshank hapishanesinde yaşamını sürdürmeye çalışırken, dostluğun ve umudun gücünü keşfeder.",
                    ProductionYear = "1994",
                    MovieDuration = "2 saat 22 dakika",
                    Country = "ABD",
                    Director = "Frank Darabont",
                    Cast = "Tim Robbins, Morgan Freeman",
                    ImdbRating = 9.3,
                    CategoryId = Guid.Parse("96F76275-6EAE-4F1D-A779-E2081708DBAF"),
                },
                new Movie
                {
                    Id = Guid.Parse("320B4694-9DD1-432F-9CAC-C0BF193EF68F"),
                    Name = "Fight Club",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BODQ0OWJiMzktYjNlYi00MzcwLThlZWMtMzRkYTY4ZDgxNzgxXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg",
                    MovieTrailerUrl = "https://youtu.be/BdJKm16Co6M",
                    Description = "Sıradan bir ofis çalışanı, karizmatik bir yabancıyla tanışarak hayatını değiştiren bir yeraltı dövüş kulübünü kurar.",
                    ProductionYear = "1999",
                    MovieDuration = "2 saat 19 dakika",
                    Country = "ABD",
                    Director = "David Fincher",
                    Cast = "Edward Norton, Brad Pitt",
                    ImdbRating = 8.8,
                    CategoryId = Guid.Parse("96F76275-6EAE-4F1D-A779-E2081708DBAF")
                },
                new Movie
                {
                    Id = Guid.Parse("46747148-7742-49D3-BC47-7B64DCFDEFAD"),
                    Name = "Inception",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_.jpg",
                    MovieTrailerUrl = "https://youtu.be/YoHD9XEInc0",
                    Description = "Dom Cobb, insanların rüyalarına girme yeteneği olan bir hırsızdır. Tehlikeli bir iş teklifi alır ve zihin çalma sanatını kullanarak karmaşık bir soygun planlar.",
                    ProductionYear = "2010",
                    MovieDuration = "2 saat 28 dakika",
                    Country = "ABD",
                    Director = "Christopher Nolan",
                    Cast = "Leonardo DiCaprio, Joseph Gordon-Levitt",
                    ImdbRating = 8.8,
                    CategoryId = Guid.Parse("D5B3A8C5-F8DC-4495-B90F-D41EA9985878")
                },
                new Movie
                {
                    Id = Guid.Parse("18FA548F-94E5-4A8C-BD07-65C7BA61CD2E"),
                    Name = "Interstellar",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_.jpg",
                    MovieTrailerUrl = "https://youtu.be/zSWdZVtXT7E",
                    Description = "Yakın bir gelecekte, dünya yaşanmaz hale gelmiştir. Cooper adlı astronot, yeni bir yaşanabilir gezegen arayışına çıkar ve zaman ile uzay arasındaki sırları keşfeder.",
                    ProductionYear = "2014",
                    MovieDuration = "2 saat 49 dakika",
                    Country = "ABD",
                    Director = "Christopher Nolan",
                    Cast = "Matthew McConaughey, Anne Hathaway",
                    ImdbRating = 8.6,
                    CategoryId = Guid.Parse("D5B3A8C5-F8DC-4495-B90F-D41EA9985878")
                },
                new Movie
                {
                    Id = Guid.Parse("C2AC8CA6-0F24-4553-B4B0-11176CADA194"),
                    Name = "The Wolf of Wall Street",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_FMjpg_UX1000_.jpg",
                    MovieTrailerUrl = "https://youtu.be/iszwuX1AK6A",
                    Description = "Jordan Belfort, finans dünyasının en ünlü dolandırıcısıdır. Zenginlik ve lüksün doruklarına tırmanırken yasadışı yollarla servet kazanır.",
                    ProductionYear = "2013",
                    MovieDuration = "3 saat",
                    Country = "ABD",
                    Director = "Martin Scorsese",
                    Cast = "Leonardo DiCaprio, Jonah Hill",
                    ImdbRating = 8.2,
                    CategoryId = Guid.Parse("4AB0190F-A4D4-49E8-8AC3-718481AA2A89")
                },
                new Movie
                {
                    Id = Guid.Parse("7644D8BB-E3D9-423E-BE5E-FD4C1138D7D0"),
                    Name = "Saw",
                    MoviePosterUrl = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg",
                    MovieTrailerUrl = "https://youtu.be/S-1QgOMQ-ls",
                    Description = "Bir dizi karmaşık ve ölümcül oyunlarla dolu bir labirentte uyanan iki yabancı, korkunç bir sırrı çözmeye çalışır.",
                    ProductionYear = "2004",
                    MovieDuration = "1 saat 43 dakika",
                    Country = "ABD",
                    Director = "James Wan",
                    Cast = "Cary Elwes, Leigh Whannell",
                    ImdbRating = 7.6,
                    CategoryId = Guid.Parse("12367738-4C57-4874-A1B6-EEBCCFE9ABA8")
                }
            );
        }
    }
}
