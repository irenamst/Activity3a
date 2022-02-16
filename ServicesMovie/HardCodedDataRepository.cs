using Activity3a.Models;
using System.Globalization;

namespace Activity3a.ServicesMovie
{
    public class HardCodedDataRepository : IMovieDataService
    {
        static List<MovieModel> moviesList = new List<MovieModel>();
        public int Delete(MovieModel movie)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> GetAllMovies()
        {
            moviesList.Add(new MovieModel
            {
                Id = 1,
                Name = "Golden eye",
                MovieType = "Action-Thriller-Adventure",
                Rating = "7.2/10",
            });

            moviesList.Add(new MovieModel
            {
                Id = 2,
                Name = "Tomorrow never dies",
                MovieType = "Action-Thriller-Adventure",
                Rating = "6.5/10",
            });

            moviesList.Add(new MovieModel
            {
                Id = 3,
                Name = "The world is not enough",
                MovieType = "Action-Thriller-Adventure",
                Rating = "6.4/10",
            });
            moviesList.Add(new MovieModel
            {
                Id = 4,
                Name = "Die another day",
                MovieType = "Action-Thriller-Adventure",
                Rating = "6.1/10",
            });
            return moviesList;
        }

        public MovieModel GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MovieModel movie)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> SearchMovies(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(MovieModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
