using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels;

namespace CinemaApp.Web.Services.Interfaces;

public interface IMovieService
{
    Task<List<AllMoviesIndexViewModel>> GetAllAsync();

    Task<Movie> GetByIdAsync(int id);
    Task AddAsync(Movie movie);
    Task UpdateAsync(Movie movie);
    Task DeleteAsync(int id);


}