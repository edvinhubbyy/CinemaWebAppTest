using CinemaApp.Data;
using CinemaApp.Data.Models;
using CinemaApp.Web;
using CinemaApp.Web.Services.Interfaces;
using CinemaApp.Web.ViewModels;
using Microsoft.EntityFrameworkCore;

public class MovieService : IMovieService
{
    private readonly CinemaAppDbContext _context;

    public MovieService(CinemaAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AllMoviesIndexViewModel>> GetAllAsync()
    {
        return await _context.Movies
            .Select(m => new AllMoviesIndexViewModel
            {
                Id = m.Id.ToString(),
                Title = m.Title,
                Genre = m.Genre,
                Director = m.Director,
                ReleaseDate = m.ReleaseDate.ToString("yyyy-MM-dd"),
                ImageUrl = m.ImageUrl
            })
            .ToListAsync();
    }

    public async Task<Movie> GetByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task AddAsync(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Movie movie)
    {
        _context.Movies.Update(movie);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }
}

