using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using IsItYours.Data;
using IsItYours.Models;

namespace IsItYours.Web.Controllers
{
	[RoutePrefix("Items")]
    public class ItemsController : Controller
    {
        private IsItYoursContext db = new IsItYoursContext();

        [Route]
		[Route("Index")]
        public ActionResult Index()
        {
			return View(db.Items.ToList());
        }

	    [Route("Details/{id}")]
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

		[Route("Create")]
        public ActionResult Create()
        {
	        if (Request.IsAuthenticated)
	        {
				return View();
			}

	        return RedirectToAction("Login", "Account");
        }

		[Route("Create")]
		[HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name,Description,TimeFound,FoundItsOwner")] Item item)
		{
			if (Request.IsAuthenticated)
			{
				if (ModelState.IsValid)
				{
					item.TimeFound = DateTime.Now;
					item.FoundItsOwner = false;
					db.Items.Add(item);
					db.SaveChanges();
					return RedirectToAction("Index");
				}

				return View(item);
			}

			return RedirectToAction("Login", "Account");
		}

		[Route("Edit/{id}")]
		public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

		[Route("Edit/{id}")]
		[HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,TimeFound,FoundItsOwner")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

		[Route("Delete/{id}")]
		public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

		[Route("Delete/{id}")]
		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
