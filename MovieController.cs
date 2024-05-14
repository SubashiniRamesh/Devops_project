using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace movie.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController1/Create
        public ActionResult Ticketbooking()
        {
            return View();
        }

        // POST: MovieController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ticketbooking(IFormCollection collection)
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

        // GET: MovieController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController1/Edit/5
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

        // GET: MovieController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController1/Delete/5
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
