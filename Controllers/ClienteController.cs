using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabajoFinalProem_GalanFlorencia.datos;
using TrabajoFinalProem_GalanFlorencia.Models;

namespace TrabajoFinalProem_GalanFlorencia.Controllers
{
    public class ClienteController : Controller
    {
        //VA LA FUNCIONALIDAD EN C#, con esto ya puedo usar razor en html
        private readonly ApplicationDbContext _contexto;
        public ClienteController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        public IActionResult Index()//async Task<IActionResult> Index()
        {
            //listar por numero de factura
            List<Factura> lista = _contexto.Factura.Include(c => c.numero).ToList();
            return View(lista);// await _contexto.Cliente.ToListAsync()
        }

        [HttpGet] //mostrar el formulario
        public IActionResult Crear() 
        {
            return View();//_contexto.Cliente.ToListAsync()
        }

        [HttpPost] //toma el dato del formulario
        public async Task<IActionResult> Crear( Cliente cliente)  
        {
            if (ModelState.IsValid) //valido
            {
                _contexto.Cliente.Add(cliente);
                await _contexto.SaveChangesAsync();
                TempData["Mensaje"]="El cliente se creo correctamente";//en los post
                return RedirectToAction("Index");
            }
            return View();//_contexto.Cliente.ToListAsync()
        }
        [HttpGet] //EDITAR
        public IActionResult Editar(int? codigo)
        {
            if(codigo == null)
            {
                return NotFound();
            }
            var cliente = _contexto.Cliente.Find(codigo);
            //va id porq en asp-route-id lo use
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente); 
        }
        [HttpPost]
        public async Task<IActionResult> Editar(Cliente cliente)
        {
            if (ModelState.IsValid) //valido
            {
                _contexto.Cliente.Update(cliente);
                await _contexto.SaveChangesAsync();
                TempData["Mensaje"] = "El cliente se edito correctamente";
                return RedirectToAction("Index");
            }
            return View(cliente);//_contexto.Cliente.ToListAsync()
        }
        [HttpGet] 
        public IActionResult Borrar(int? codigo)
        {
            if (codigo == null)
            {
                return NotFound();
            }
            var cliente = _contexto.Cliente.Find(codigo);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
        [HttpPost]
 //        [ValidateAntiForgeryToken] //van en los post
        public async Task<IActionResult> BorrarRegistro(int codigo)
        {
            var cliente = await _contexto.Cliente.FindAsync(codigo);
            if (cliente == null)
            {
                return NotFound();
            }
            _contexto.Cliente.Remove(cliente);
            await _contexto.SaveChangesAsync();
            TempData["Mensaje"] = "El cliente se borro correctamente";
            return RedirectToAction("Index");
        }
        
        




    }
}
