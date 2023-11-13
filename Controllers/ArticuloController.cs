using Microsoft.AspNetCore.Mvc;
using Proyecto24AM.Models.Entities;
using Proyecto24AM.Services.IServices;

namespace Proyecto24AM.Controllers
{
    public class ArticuloController : Controller
    {
        private readonly IArticuloServices _articuloServices;
        public ArticuloController(IArticuloServices articuloServices)
        {
            _articuloServices = articuloServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var response = await _articuloServices.GetArticulos();
                return View(response);
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR: " + ex);
            }
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Articulo request)
        {
            try
            {
                var response = _articuloServices.CrearArticulo(request);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw new Exception("ERROR: " + ex);
            }
        }
    }
}
