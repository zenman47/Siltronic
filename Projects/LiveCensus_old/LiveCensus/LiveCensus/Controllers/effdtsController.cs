using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LiveCensus.Models;

namespace LiveCensus.Controllers
{
    public class effdtsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: effdts
        public ActionResult Index()
        {
            return View(db.effdts.ToList());
        }

        // GET: effdts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            effdt effdt = db.effdts.Find(id);
            if (effdt == null)
            {
                return HttpNotFound();
            }
            return View(effdt);
        }

        // GET: effdts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: effdts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,EffDate")] effdt effdt)
        {
            if (ModelState.IsValid)
            {
                db.effdts.Add(effdt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(effdt);
        }

        // GET: effdts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            effdt effdt = db.effdts.Find(id);
            if (effdt == null)
            {
                return HttpNotFound();
            }
            return View(effdt);
        }

        // POST: effdts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,EffDate")] effdt effdt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(effdt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(effdt);
        }

        // GET: effdts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            effdt effdt = db.effdts.Find(id);
            if (effdt == null)
            {
                return HttpNotFound();
            }
            return View(effdt);
        }

        // POST: effdts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            effdt effdt = db.effdts.Find(id);
            db.effdts.Remove(effdt);
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
