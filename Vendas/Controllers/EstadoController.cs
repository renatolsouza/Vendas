using Microsoft.AspNetCore.Mvc;
using Vendas.Data;
using Vendas.DTOs;
using Vendas.Models.Cadastro;

namespace Vendas.Controllers
{

    public class EstadoController : Controller
    {

        readonly private AplicationDbContext _db;


        public EstadoController(AplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EstadoModel> estado = _db.Estado;

            return View(estado);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EstadoModel estado)
        {
            if (ModelState.IsValid)
            {
                _db.Estado.Add(estado);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            EstadoModel estado = _db.Estado.FirstOrDefault(x => x.IDESTADO == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        [HttpPost]
        public IActionResult Editar(EstadoModel estado)
        {
            if (ModelState.IsValid)
            {
                _db.Estado.Update(estado);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(estado);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            EstadoModel estado = _db.Estado.FirstOrDefault(x => x.IDESTADO == id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        [HttpPost]
        public IActionResult Excluir(EstadoModel estado)
        {

            if (estado == null)
            {
                return NotFound();
            }


            _db.Estado.Remove(estado);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }

        public static List<EstadoDto> GetEstados(AplicationDbContext _db)
        {
            List<EstadoDto> obj = new List<EstadoDto>();

            var resultado = from c in _db.Estado
                             
                             select new
                             {
                                 c.IDESTADO,
                                 c.NOME                                

                             };

            foreach (var item in resultado)
            {
                EstadoDto clr = new EstadoDto();

                clr.IDESTADO = item.IDESTADO;
                clr.NOME = item.NOME;
                
                obj.Add(clr);

            }

            return obj;

        }
    }
}




