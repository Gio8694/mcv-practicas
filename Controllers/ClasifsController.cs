using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Noticiero.Models;

namespace Noticiero.Controllers
{
    public class ClasifsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Clasifs
        public ActionResult Index()
        {
            return View(db.Clasifs.ToList());
        }

        // GET: Clasifs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasif clasif = db.Clasifs.Find(id);
            if (clasif == null)
            {
                return HttpNotFound();
            }
            return View(clasif);
        }

        // GET: Clasifs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clasifs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClasifID,Nombre,Estado")] Clasif clasif)
        {
            if (ModelState.IsValid)
            {
                db.Clasifs.Add(clasif);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasif);
        }

        // GET: Clasifs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasif clasif = db.Clasifs.Find(id);
            if (clasif == null)
            {
                return HttpNotFound();
            }
            return View(clasif);
        }

        // POST: Clasifs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClasifID,Nombre,Estado")] Clasif clasif)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasif).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasif);
        }

        // GET: Clasifs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clasif clasif = db.Clasifs.Find(id);
            if (clasif == null)
            {
                return HttpNotFound();
            }
            return View(clasif);
        }

        // POST: Clasifs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clasif clasif = db.Clasifs.Find(id);
            db.Clasifs.Remove(clasif);
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
