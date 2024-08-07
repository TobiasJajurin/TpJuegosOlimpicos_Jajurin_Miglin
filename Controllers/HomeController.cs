using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TpJuegosOlimpicos_Jajurin_Miglin.Models;

namespace TpJuegosOlimpicos_Jajurin_Miglin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Deportes()
    {
        ViewBag.Deportes = new List<Deporte>();
        return View();
    }

    public IActionResult Pais()
    {
        ViewBag.Paises = new List<Pais>();
        return View();
    }

    
}
