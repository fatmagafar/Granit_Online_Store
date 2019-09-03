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
    }
}