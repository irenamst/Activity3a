using Activity3a.Models;
namespace Activity3a.ServicesMovie
{
    public interface IMovieDataService
    {
        List<MovieModel> GetAllMovies();
        List<MovieModel> SearchMovies(string searchTerm);
        MovieModel GetMovieById(int id);

        int Insert(MovieModel movie);
        int Delete(MovieModel movie);
        int Update(MovieModel movie);


    }
}
