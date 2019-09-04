using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Granite_online_store.Data;
using Granite_online_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Granite_online_store.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Index()
        {
            
            return View(_db.ProductTypes.ToList());
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Add(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //Edit product type
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            
            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();

            }
            return View(productType);
        }
        [HttpPost]
        public IActionResult Edit(int id ,ProductTypes productTypes)
        {
            if (id != productTypes.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
        //Details product type
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();

            }
            return View(productType);
        }
        [HttpPost]
        public IActionResult Details(int id, ProductTypes productTypes)
        {
            if (id != productTypes.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
        // Delete
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }

            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();

            }
            return View(productType);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var productType = _db.ProductTypes.Find(id);
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Remove(productType);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}