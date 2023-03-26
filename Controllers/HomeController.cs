using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Quiz_Programacao.Models;
using Quiz_Programacao.Persistence;

namespace Quiz_Programacao.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IQuizRepository _quizRepository;

    public HomeController(ILogger<HomeController> logger, IQuizRepository quizRepository)
    {
        _logger = logger;
        _quizRepository = quizRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
