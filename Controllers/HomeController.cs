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

        ViewBag.DeporteInfo = Bd.VerInfoDeporte(idDeporte);
        ViewBag.ListarDeportistasDep = Bd.ListarDeportistasPorDeporte(idDeporte);

        return View();

    }

     public IActionResult VerDetallePais(int idPais)
    {

        ViewBag.PaisInfo = Bd.VerInfoPais(idPais);
        ViewBag.ListarDeportistasPais = Bd.ListarDeportistasPorPais(idPais);

        return View();

    }

      public IActionResult VerDetalleDeportista (int idDeportista)
    {

        ViewBag.DeportistaInfo = Bd.VerInfoDeportista(idDeportista);
        return View();

    }

     public IActionResult AgregarDeportista ()
    {

        ViewBag.ListadoPaises = Bd.ListarPaises();
        ViewBag.ListadoDeportes = Bd.ListarDeportes();
        return View();

    }
    public IActionResult EliminarDeportista (int idCandidato)
    {

        Bd.EliminarDeportista(idCandidato);
        return View(Index);

    }
    [HttpPost] IActionResult GuardarDeportista(Deportista dep)
    {
        Bd.AgregarDeportista(dep);
        return View(Index);
    }

}
