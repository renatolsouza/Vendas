using Microsoft.AspNetCore.Mvc;
using Vendas.Data;
using Vendas.Models.Cadastro;

namespace Vendas.Controllers
{
    public class EmpresaController : Controller
    {

        readonly private AplicationDbContext _db;


        public EmpresaController(AplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmpresaModel> empresa = _db.Empresa;

            return View(empresa);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmpresaModel empresa)
        {
            if (ModelState.IsValid)
            {
                _db.Empresa.Add(empresa);
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
            EmpresaModel empresa = _db.Empresa.FirstOrDefault(x => x.Idempresa == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        [HttpPost]
        public IActionResult Editar(EmpresaModel empresa)
        {
            if (ModelState.IsValid)
            {
                _db.Empresa.Update(empresa);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(empresa);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            EmpresaModel empresa = _db.Empresa.FirstOrDefault(x => x.Idempresa == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        [HttpPost]
        public IActionResult Excluir(EmpresaModel empresa)
        {

            if (empresa == null)
            {
                return NotFound();
            }


            _db.Empresa.Remove(empresa);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
