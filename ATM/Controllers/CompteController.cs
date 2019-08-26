using ATM.Models;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class CompteController : Controller
    {
        // GET: Compte
        public ActionResult Index()
        {
            return View();
        }

        // GET: Compte/Details/5
        public ActionResult Details()
        {
            var verifCompte = new VerificationCompte
            {
                NumeroCompte = "00000012345648",
                Nom = "Foulen",
                Prenom = "Foulen",
                Solde = 54895,
                Id = 1
            };
            return View(verifCompte);
        }

        // GET: Compte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compte/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Compte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Compte/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Compte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Compte/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
