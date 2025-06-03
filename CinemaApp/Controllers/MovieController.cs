using CinemaApp.Web.ViewModels;
using CinemaApp.Web.ViewModels.Movie;
using Microsoft.AspNetCore.Mvc;
using static CinemaApp.GCommon.Movie;

namespace CinemaApp.Web.Controllers;

public class MovieController : Controller
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<AllMoviesIndexViewModel> allMovies = await this._movieService.GetAllMoviesTaskAsync();

        return View(allMovies);
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(MovieFormInputModel inputModel)
    {

        if (!ModelState.IsValid)
        {
            return View(inputModel);
        }

        try
        {
            await this._movieService.AddMovieAsync(inputModel);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception e)
        {
            this.ModelState.AddModelError(string.Empty, ServiceCreatingError);
            return this.View(inputModel);
        }

        

    }

}