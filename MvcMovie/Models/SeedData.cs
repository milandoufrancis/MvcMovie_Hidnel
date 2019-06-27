using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
                        Title = "Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        Genre = "Comedy, Drama",
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("2005-1-1"),
                        Genre = "Biography, Drama, History",
                        Rating = "None",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2002-4-12"),
                        Genre = "Adventure, Biography, Drama",
                        Rating = "PG",
                        Price = 14.98M
                    },

                    new Movie
                    {
                        Title = "Trek: The Movie",
                        ReleaseDate = DateTime.Parse("2008-4-6"),
                        Genre = "Comedy, Drama, Family",
                        Rating = "PG",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "Come Unto Me",
                        ReleaseDate = DateTime.Parse("2014-4-1"),
                        Genre = "Short, Drama, Family",
                        Rating = "None",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure, History",
                        Rating = "PG",
                        Price = 14.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}