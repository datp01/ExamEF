using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practive.Models;

namespace practive.Controllers
{
    public class ExamController : Controller
    {
        private readonly DatabaseContext _context;
        public ExamController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: ExamController
        public ActionResult Index()
        {
            return View(_context.Exams.ToList());
        }

        // GET: ExamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamController/Create
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

        // GET: ExamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamController/Edit/5
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

        // GET: ExamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamController/Delete/5
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
