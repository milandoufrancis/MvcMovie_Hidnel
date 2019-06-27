using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public PaginatedList<Movie> Movies;
        public SelectList Genres;
    }
}
