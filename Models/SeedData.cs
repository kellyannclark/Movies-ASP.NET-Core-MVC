using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Rating = "PG",
                        Price = 6.99M,
                        ImageName = "17_Miracles.jpg" // Example image name
                    },
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-4-12"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 7.99M,
                        ImageName = "The_Other_Side_of_Heaven.jpg" // Example image name
                    },
                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-9"),
                        Genre = "Action",
                        Rating = "PG",
                        Price = 8.99M,
                        ImageName = "The_Saratov_Approach.jpg" // Example image name
                    },
                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 4.99M,
                        ImageName = "Meet_the_Mormons.jpg" // Example image name
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
