using EV.Data;
using EV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EV.Controllers
{
    [Authorize]
    public class IventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public IventController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Ivent> obList = _db.Ivent;
            return View(obList);
        }
        //GET - CTEATE
        public IActionResult Create()
        {

            return View();
        }

        //Post - CTEATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ivent obj)
        {
            if (ModelState.IsValid)
            {
                _db.Ivent.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
           
        }
        //GET -Upsert
        public IActionResult Upsert(int? id)
        {
            Ivent ivent = new Ivent();
            if(id==null)
            {
                return View(ivent);
            }
            else
            {
                ivent = _db.Ivent.Find(id);
                if (ivent == null) {
                    return NotFound();
                }
                return NotFound(ivent);
            }
        }
        //Post - Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Ivent obj)
        {
            if (ModelState.IsValid)
            {
                _db.Ivent.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {

            return View();
        }

       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {

            return View();
        }*/


    }
}
