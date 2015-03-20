using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LiveCensus2.Models;

namespace LiveCensus2.Controllers
{
    public class Team1Controller : Controller
    {
        private Team1Data db = new Team1Data();

        // GET: Team1
        public ActionResult Index()
        {
            var lCEN_TEAM1 = db.LCEN_TEAM1.Include(t => t.LCEN_HOURS).Include(t => t.LCEN_SHIFTS).Include(t => t.LCEN_USERS).Include(t => t.LCEN_USERS1);
            return View(lCEN_TEAM1.ToList());
        }

        // GET: Team1/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.LCEN_TEAM1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            return View(team1);
        }

        // GET: Team1/Create
        public ActionResult Create()
        {
            ViewBag.HOUR = new SelectList(db.LCEN_HOURS, "HOUR_ID", "HRNUM");
            ViewBag.SHIFT = new SelectList(db.LCEN_SHIFTS, "SHIFT_ID", "SHIFTNUM");
            ViewBag.CREATEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME");
            ViewBag.EDITEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME");
            return View();
        }

        // POST: Team1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EFFDT,HOUR,SHIFT,CREATEDBY,CREATEDDT,EDITEDBY,EDITEDDT,CELL1,CELL2,CELL3,CELL4,CELL6,CELL7")] Team1 team1)
        {
            if (ModelState.IsValid)
            {
                db.LCEN_TEAM1.Add(team1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HOUR = new SelectList(db.LCEN_HOURS, "HOUR_ID", "HRNUM", team1.HOUR);
            ViewBag.SHIFT = new SelectList(db.LCEN_SHIFTS, "SHIFT_ID", "SHIFTNUM", team1.SHIFT);
            ViewBag.CREATEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.CREATEDBY);
            ViewBag.EDITEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.EDITEDBY);
            return View(team1);
        }

        // GET: Team1/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.LCEN_TEAM1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.HOUR = new SelectList(db.LCEN_HOURS, "HOUR_ID", "HRNUM", team1.HOUR);
            ViewBag.SHIFT = new SelectList(db.LCEN_SHIFTS, "SHIFT_ID", "SHIFTNUM", team1.SHIFT);
            ViewBag.CREATEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.CREATEDBY);
            ViewBag.EDITEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.EDITEDBY);
            return View(team1);
        }

        // POST: Team1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EFFDT,HOUR,SHIFT,CREATEDBY,CREATEDDT,EDITEDBY,EDITEDDT,CELL1,CELL2,CELL3,CELL4,CELL6,CELL7")] Team1 team1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(team1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HOUR = new SelectList(db.LCEN_HOURS, "HOUR_ID", "HRNUM", team1.HOUR);
            ViewBag.SHIFT = new SelectList(db.LCEN_SHIFTS, "SHIFT_ID", "SHIFTNUM", team1.SHIFT);
            ViewBag.CREATEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.CREATEDBY);
            ViewBag.EDITEDBY = new SelectList(db.LCEN_USERS, "USERID", "FIRST_NAME", team1.EDITEDBY);
            return View(team1);
        }

        // GET: Team1/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Team1 team1 = db.LCEN_TEAM1.Find(id);
            if (team1 == null)
            {
                return HttpNotFound();
            }
            return View(team1);
        }

        // POST: Team1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            Team1 team1 = db.LCEN_TEAM1.Find(id);
            db.LCEN_TEAM1.Remove(team1);
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
