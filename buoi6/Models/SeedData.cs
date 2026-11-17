using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using buoi6.Data;
using System;
using System.Linq;

namespace buoi6.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new buoi6Context(
                serviceProvider.GetRequiredService<DbContextOptions<buoi6Context>>()))
            {
                // Nếu đã có dữ liệu Genre thì bỏ qua
                if (!context.Genre.Any())
                {
                    var actionGenre = new Genre { Name = "Action" };
                    var animationGenre = new Genre { Name = "Animation" };
                    var fantasyGenre = new Genre { Name = "Fantasy" };
                    var comedyGenre = new Genre { Name = "Romantic Comedy" };
                    var westernGenre = new Genre { Name = "Western" };

                    context.Genre.AddRange(actionGenre, animationGenre, fantasyGenre, comedyGenre, westernGenre);
                    context.SaveChanges();

                    if (!context.Movie.Any())
                    {
                        context.Movie.AddRange(
                            new Movie
                            {
                                Title = "When Harry Met Sally",
                                ReleaseDate = DateTime.Parse("1989-02-12"),
                                GenreId = comedyGenre.Id,
                                Price = 7.99M
                            },
                            new Movie
                            {
                                Title = "Ghostbusters",
                                ReleaseDate = DateTime.Parse("1984-03-13"),
                                GenreId = actionGenre.Id,
                                Price = 8.99M
                            },
                            new Movie
                            {
                                Title = "Toy Story",
                                ReleaseDate = DateTime.Parse("1995-11-22"),
                                GenreId = animationGenre.Id,
                                Price = 9.99M
                            },
                            new Movie
                            {
                                Title = "Rio Bravo",
                                ReleaseDate = DateTime.Parse("1959-04-15"),
                                GenreId = westernGenre.Id,
                                Price = 3.99M
                            }
                        );
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
