using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Controllers
{
    public class ConteudoController : Controller
    {
        // GET: ConteudoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConteudoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConteudoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConteudoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
