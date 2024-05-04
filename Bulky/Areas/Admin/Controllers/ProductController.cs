using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository;
using Bulky.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Framework;
using System.Reflection;
using System.Security.Policy;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork _db, IWebHostEnvironment webHostEnvironment)
        {

            _unitOfWork = _db;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index(){
            List<Product> product1 = _unitOfWork.product.GetAll(includeProperties:"Category").ToList();
            return View(product1);
        }
        public IActionResult Upsert(int? id)
        {
            
            ProductVM productVM = new()
            {
                categoryList = _unitOfWork.category.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.CategoryId.ToString()
                }),
                Product = new Product()

            };
            if (id == null || id == 0)
            {


                return View(productVM);

            }
            else
            {
                productVM.Product = _unitOfWork.product.Get(u => u.ProductId == id);
                return View(productVM); 
            }
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM obj, IFormFile? file)
        {


            obj.Product.ProductId = 0;
            if (ModelState.IsValid)
            {
                if (file != null) {
                    string wwwRoothpath=_webHostEnvironment.WebRootPath;

                    string filename=Guid.NewGuid().ToString()+Path.GetExtension(file.FileName);
                    string productpath = Path.Combine(wwwRoothpath, @"Image\Product");
                    using (var filestream =new FileStream(Path.Combine(productpath, filename), FileMode.Create))
                    {
                        file.CopyTo(filestream);
                    }
                    obj.Product.ImageUrl = @"\Image\Product" + filename;
                }
                _unitOfWork.product.Add(obj.Product);
                _unitOfWork.Save();
                TempData["success"] = "Record Added Successfully";
                return RedirectToAction("Index");
            }
            else {

                return View();
            }
        }


        
        
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> product1 = _unitOfWork.product.GetAll(includeProperties: "Category").ToList();
            return Json(new {data=product1 });   
        }
       
        public IActionResult Delete(int? id)
        {
            Product cat = _unitOfWork.product.Get(u => u.ProductId == id);

           
            if (cat == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            
            _unitOfWork.product.Remove(cat);
            _unitOfWork.Save();
            return Json(new { success=true, message="Deleted Successfully" });
        }

        #endregion


    }

}
