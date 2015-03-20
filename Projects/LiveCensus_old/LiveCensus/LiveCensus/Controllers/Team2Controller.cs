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
    public class Team2Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Team2
        public ActionResult Index()
        {
            return View(db.Team2.ToList());
        }

        // GET: Team2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team2 team2 = db.Team2.Find(id);
            if (team2 == null)
            {
                return HttpNotFound();
            }
            return View(team2);
        }

        // GET: Team2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cell5,cell8,cell9,CreatedBy,EditedBy,EditDt")] Team2 team2)
        {
            if (ModelState.IsValid)
            {
                db.Team2.Add(team2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team2);
        }

        // GET: Team2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team2 team2 = db.Team2.Find(id);
            if (team2 == null)
            {
                return HttpNotFound();
            }
            return View(team2);
        }

        // POST: Team2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cell5,cell8,cell9,CreatedBy,EditedBy,EditDt")] Team2 team2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(team2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team2);
        }

        // GET: Team2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team2 team2 = db.Team2.Find(id);
            if (team2 == null)
            {
                return HttpNotFound();
            }
            return View(team2);
        }

        // POST: Team2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Team2 team2 = db.Team2.Find(id);
            db.Team2.Remove(team2);
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
