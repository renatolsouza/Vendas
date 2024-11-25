using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using Vendas.Data;
using Vendas.Models.Cadastro;


namespace Vendas.Controllers
{
    public class CidadeController : Controller
    {

        readonly private AplicationDbContext _db;


        public CidadeController(AplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

           

            //var resultado = _db.Cidade.Join(
            //    _db.Estado,
            //    C => C.Uf,
            //    E => E.IDESTADO,
            //    (C, E) => new { C, E })

            //    .Select(s => new {
            //        s.C.IDCIDADE,
            //        s.C.NOME,
            //        s.C.Uf,
            //        s.C.IBGE

            //    }).ToList();

            IEnumerable<CidadeModel> cidade = _db.Cidade;

            return View(cidade);


        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CidadeModel cidade)
        {            
            if (ModelState.IsValid)
            {
                _db.Cidade.Add(cidade);
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
            CidadeModel cidade = _db.Cidade.FirstOrDefault(x => x.IDCIDADE == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        public IActionResult Editar(CidadeModel cidade)
        {
            if (ModelState.IsValid)
            {
                _db.Cidade.Update(cidade);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(cidade);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            CidadeModel cidade = _db.Cidade.FirstOrDefault(x => x.IDCIDADE == id);
            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        public IActionResult Excluir(CidadeModel cidade)
        {

            if (cidade == null)
            {
                return NotFound();
            }


            _db.Cidade.Remove(cidade);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
