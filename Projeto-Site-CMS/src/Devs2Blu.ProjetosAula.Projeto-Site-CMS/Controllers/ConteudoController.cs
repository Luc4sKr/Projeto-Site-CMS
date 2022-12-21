using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Controllers
{
    public class ConteudoController : Controller
    {
        private readonly IConteudoService _service;
        private readonly ICategoriaService _serviceCategoria;

        public ConteudoController(IConteudoService service, ICategoriaService serviceCategoria)
        {
            _service = service;
            _serviceCategoria = serviceCategoria;
        }

        // GET: ConteudoController
        public async Task<ActionResult> Index()
        {
            return View(await _service.GetAllConteudos());
        }

        // GET: ConteudoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConteudoController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["CategoriaId"] = new SelectList(await _serviceCategoria.GetAllCategorias(), "Id", "Id");
            return View();
        }

        // POST: ConteudoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nome,Descricao,Preco,CategoriaId,IsPublished,IdDeleted,CreateDate")] Conteudo conteudo)
        {
            if (ModelState.IsValid)
            {
                await _service.Save(conteudo);
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(conteudo);
            }
        }

        // GET: ConteudoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConteudoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConteudoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConteudoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
