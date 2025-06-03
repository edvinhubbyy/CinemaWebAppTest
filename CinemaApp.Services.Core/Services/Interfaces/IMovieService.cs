using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels;
using CinemaApp.Web.ViewModels.Movie;

public interface IMovieService
{
    Task<IEnumerable<AllMoviesIndexViewModel>> GetAllMoviesTaskAsync();

    Task AddMovieAsync(MovieFormInputModel inputModel);

}