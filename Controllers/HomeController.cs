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
        ViewBag.Deportes = Bd.ListarDeportes() ;
        return View();
    }

    public IActionResult Paises()
    {
        ViewBag.Paises = Bd.ListarPaises();
        return View();
    }

    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.Deporte = Bd.VerInfoDeporte();
    }

    
}
