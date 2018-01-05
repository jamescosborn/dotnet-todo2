using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Locations.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Locations.Controllers
{
    public class LocationsController : Controller
    {
		public IActionResult Create()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

		private LocationsContext db = new LocationsContext();
		public IActionResult Index()
		{
			List<Location> model = db.Locations.ToList();
			return View(model);
		}


		public IActionResult Details(int id)
		{
			Location thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
			return View(thisLocation);
		}

		public IActionResult Edit(int id)
		{
			var thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
			return View(thisLocation);
		}

		[HttpPost]
		public IActionResult Edit(Location location)
		{
			db.Entry(location).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			var thisItem = db.Locations.FirstOrDefault(location => location.LocationId == id);
			return View(thisItem);
		}

		[HttpPost, ActionName("Delete")]
		public IActionResult DeleteConfirmed(int id)
		{
			var thisLocation = db.Locations.FirstOrDefault(location => location.LocationId == id);
			db.Locations.Remove(thisLocation);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
    }
}
