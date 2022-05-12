using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabajoFinalProem_GalanFlorencia.datos;
using TrabajoFinalProem_GalanFlorencia.Models;

namespace TrabajoFinalProem_GalanFlorencia.Controllers
{
    public class FacturaController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public FacturaController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        public async Task<IActionResult> Index() //llama al index
        {
            return View(await _contexto.Factura.ToListAsync());
        }
        // CREAR
        [HttpGet]  
        public IActionResult Crear()
        {
            return View(); 
        }
        [HttpPost]  
        public async Task<IActionResult> Crear(Factura factura)
        {
            if (ModelState.IsValid) //valido
            {
                _contexto.Factura.Add(factura);
                await _contexto.SaveChangesAsync();
                TempData["Mensaje"] = "La factura se creo correctamente";//en los post
                return RedirectToAction("Index");
            }
            return View(); 
        }
        //EDITAR
        [HttpGet] 
        public IActionResult Editar(int? numero)
        {
            if (numero == null)
            {
                return NotFound();
            }
            var factura = _contexto.Factura.Find(numero);
            if (factura == null)
            {
                return NotFound();
            }
            return View(factura);
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Factura factura)
        {
            if (ModelState.IsValid) //valido
            {
                _contexto.Factura.Update(factura);
                await _contexto.SaveChangesAsync();
                TempData["Mensaje"] = "La factura se edito correctamente";
                return RedirectToAction("Index");
            }
            return View(factura);
        }
        [HttpGet]
        public IActionResult Borrar(int? numero)
        {
            if (numero == null)
            {
                return NotFound();
            }
            var factura = _contexto.Factura.Find(numero);
            if (factura == null)
            {
                return NotFound();
            }
            return View(factura);
        }
        [HttpPost]
        public async Task<IActionResult> BorrarRegistro(int? numero)
        {
            var factura = await _contexto.Factura.FindAsync(numero);
            if (factura == null)
            {
                return NotFound();
            }
            _contexto.Factura.Remove(factura);
            await _contexto.SaveChangesAsync();
            TempData["Mensaje"] = "La factura se borro correctamente";
            return RedirectToAction("Index");
        }










    }
}
