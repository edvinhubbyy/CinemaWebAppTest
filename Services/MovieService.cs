using CinemaApp.Data;
using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Services;

public class MovieService : IMovieService
{
    private readonly CinemaAppDbContext _context;

    public MovieService(CinemaAppDbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {
        return await _context.Movies.ToListAsync();
    }

    public async Task<Movie> GetMovieByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task AddMovieAsync(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateMovieAsync(Movie movie)
    {
        _context.Movies.Update(movie);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMovieAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }
}