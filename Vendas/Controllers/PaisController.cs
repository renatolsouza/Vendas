using Microsoft.AspNetCore.Mvc;
using Vendas.Data;
using Vendas.Models.Cadastro;

namespace Vendas.Controllers
{
    public class PaisController : Controller
    {

        readonly private AplicationDbContext _db;


        public PaisController(AplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<PaisModel> pais = _db.Pais;

            return View(pais);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PaisModel pais)
        {
            if (ModelState.IsValid)
            {
                _db.Pais.Add(pais);
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
            PaisModel pais = _db.Pais.FirstOrDefault(x => x.IDPAIS == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        [HttpPost]
        public IActionResult Editar(PaisModel pais)
        {
            if (ModelState.IsValid)
            {
                _db.Pais.Update(pais);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(pais);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            PaisModel pais = _db.Pais.FirstOrDefault(x => x.IDPAIS == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        [HttpPost]
        public IActionResult Excluir(PaisModel pais)
        {

            if (pais == null)
            {
                return NotFound();
            }


            _db.Pais.Remove(pais);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
