using System.Globalization;
using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Web.ViewModels;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.EntityFrameworkCore;
using static CinemaApp.GCommon.EntityConstants;

public class MovieService : IMovieService
{
    private readonly CinemaAppDbContext _dbContext;

    public MovieService(CinemaAppDbContext context)
    {
        _dbContext = context;
    }

    public async Task<IEnumerable<AllMoviesIndexViewModel>> GetAllMoviesTaskAsync()
    {
        IEnumerable<AllMoviesIndexViewModel> allMovies = await this._dbContext
            .Movies
            .AsNoTracking()
            .Select(m => new AllMoviesIndexViewModel
            {
                Id = m.Id.ToString(),
                Title = m.Title,
                Genre = m.Genre,
                Director = m.Director,
                ReleaseDate = m.ReleaseDate.ToString(AppDateFormat),
                ImageUrl = m.ImageUrl
            })
            .ToListAsync();

        return allMovies;
    }

    public async Task AddMovieAsync(MovieFormInputModel inputModel)
    {
        Movie newMovie = new Movie
        {
            Title = inputModel.Title,
            Genre = inputModel.Genre,
            Director = inputModel.Director,
            Description = inputModel.Description,
            Duration = inputModel.Duration,
            ImageUrl = inputModel.ImageUrl,
            ReleaseDate = DateOnly.ParseExact(inputModel.ReleaseDate, AppDateFormat, CultureInfo.InvariantCulture,
                DateTimeStyles.None)
        };

        await _dbContext.Movies.AddAsync(newMovie);
        await _dbContext.SaveChangesAsync();
    }

}