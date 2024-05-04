using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository;
using Bulky.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _db;
        public CategoryController(IUnitOfWork db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> list = _db.category.GetAll().ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Display order should not be same with Name");
            }
            if (obj.Name == "test")
            {
                ModelState.AddModelError("name", "Should not exactly match");
            }
            if (ModelState.IsValid)
            {
                _db.category.Add(obj);
                TempData["success"] = "Record Created Successfully";
                _db.Save();
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.category.Get(u => u.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.category.Update(obj);
                _db.Save();
                TempData["success"] = "Record Edited Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.category.Get(u => u.CategoryId == id);
            return View(category);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {


            Category category = _db.category.Get(u => u.CategoryId == id);
            _db.category.Remove(category);
            _db.Save();
            TempData["success"] = "Record Deleted Successfully";
            return RedirectToAction("Index");

        }



    }

}
