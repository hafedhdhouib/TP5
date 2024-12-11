using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP5.Models;

namespace TP5.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ApplicationContext context;

        public CategorieController(ApplicationContext context)
        {
            this.context = context;
        }
        // GET: Categorie
        public ActionResult Index()
        {
            return View(context.Categorias.ToList());
        }

        // GET: Categorie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categorie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorie categorie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Categorias.Add(categorie);
                    context.SaveChanges();
                return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categorie/Edit/5
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

        // GET: Categorie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categorie/Delete/5
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
