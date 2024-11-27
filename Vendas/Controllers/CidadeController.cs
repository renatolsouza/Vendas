using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Collections.Immutable;
using Vendas.Data;
using Vendas.DTOs;
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
           
            return View();

        }

        [HttpGet]
        public IActionResult index()
        {

            List<CidadeDto> obj = new List<CidadeDto>();

            var resultado = (from c in _db.Cidade
                             join e in _db.Estado on c.Uf equals e.IDESTADO
                             //where c.IDCIDADE == id
                             select new
                             {
                                 c.IDCIDADE,
                                 c.NOME,
                                 UF = c.Uf,
                                 NOMEUF = e.NOME,
                                 c.IBGE

                             });

            foreach (var item in resultado)
            {
                CidadeDto clr = new CidadeDto();

                clr.IDCIDADE = item.IDCIDADE;
                clr.NOME = item.NOME;
                clr.Uf = item.UF;
                clr.NOMEUF = item.NOMEUF;
                clr.IBGE = item.IBGE;

                obj.Add(clr);

            }
                           
                return View(obj);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {

            CarregaComboEstados();


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
            CarregaComboEstados();

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
            CarregaComboEstados();

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
        public void CarregaComboEstados()
        {
            //-- Carrega os estados em uma ViewBag pra popular combobox
            ViewBag.Estados = EstadoController.GetEstados(_db).Select(c => new SelectListItem()
            { Text = c.NOME, Value = c.IDESTADO.ToString() }).ToList();

        }
    }
}
