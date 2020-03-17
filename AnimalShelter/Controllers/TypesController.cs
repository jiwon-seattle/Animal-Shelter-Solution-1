using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
    public class TypesController : Controller
    {
        private readonly AnimalShelterContext _db;
        public TypesController(AnimalShelterContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Types> model = _db.Types.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Types types)
        {
            _db.Types.Add(types);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Types thisTypes = _db.Types.FirstOrDefault(types => types.TypesId == id);
            return View(thisTypes);
        }
        public ActionResult Edit(int id)
        {
            Types thisTypes = _db.Types.FirstOrDefault(types => types.TypesId == id);
            return View(thisTypes);
        }
        [HttpPost]
        public ActionResult Edit(Types Types)
        {
            _db.Entry(Types).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Types thisTypes = _db.Types.FirstOrDefault(types => types.TypesId == id);
            return View(thisTypes);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Types thisTypes = _db.Types.FirstOrDefault(types => types.TypesId == id);
            _db.Types.Remove(thisTypes);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}