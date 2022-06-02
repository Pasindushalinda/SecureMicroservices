using Movies.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.API.Data
{
    public class MovieContextSeed
    {
        public static void SeedAsync(MoviesAPIContext moviesContext)
        {
            if (!moviesContext.Movie.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Comics",
                        Title = "asd",
                        Rating = "9.2",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "Ed"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre = "Romance",
                        Title = "Forrest Gump",
                        Rating = "9",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "swn"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre = "Action",
                        Title = "Bond",
                        Rating = "8.2",
                        ImageUrl = "images/src",
                        ReleaseDate = DateTime.Now,
                        Owner = "Jim"
                    },
                    new Movie
                    {
                        Id = 4,
                        Genre = "Action",
                        Title = "Kill",
                        Rating = "7.5",
                        ImageUrl = "images/src",
                        ReleaseDate = new DateTime(1994,5,5),
                        Owner = "Tom"
                    },
                };
                moviesContext.Movie.AddRange(movies);
                moviesContext.SaveChanges();
            }
        }
    }
}
