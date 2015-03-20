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
    public class Team1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Team1
        public ActionResult Index()
        {
            return View(db.Team1.ToList());
        }

        // GET: Team1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.Team1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            return View(team1);
        }

        // GET: Team1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Team1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cell1,cell2,cell3,cell4,cell6,cell7,CreatedBy,EditedBy,EditDt")] Team1 team1)
        {
            if (ModelState.IsValid)
            {
                db.Team1.Add(team1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team1);
        }

        // GET: Team1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.Team1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            return View(team1);
        }

        // POST: Team1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cell1,cell2,cell3,cell4,cell6,cell7,CreatedBy,EditedBy,EditDt")] Team1 team1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(team1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team1);
        }

        // GET: Team1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.Team1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            return View(team1);
        }

        // POST: Team1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Team1 team1 = db.Team1.Find(id);
            db.Team1.Remove(team1);
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
