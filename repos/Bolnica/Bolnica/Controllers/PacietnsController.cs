using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bolnica.Models;

namespace Bolnica.Controllers
{
    public class PacietnsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pacietns
        public ActionResult Index()
        {
            return View(db.pacienti.ToList());
        }
        public ActionResult Nov()
        {
            return View();
        }

        // GET: Pacietns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacietn pacietn = db.pacienti.Find(id);
            if (pacietn == null)
            {
                return HttpNotFound();
            }
            return View(pacietn);
        }

        // GET: Pacietns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacietns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Kod,Name,SName")] Pacietn pacietn)
        {
            if (ModelState.IsValid)
            {
                db.pacienti.Add(pacietn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pacietn);
        }

        // GET: Pacietns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacietn pacietn = db.pacienti.Find(id);
            if (pacietn == null)
            {
                return HttpNotFound();
            }
            return View(pacietn);
        }

        // POST: Pacietns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Kod,Name,SName")] Pacietn pacietn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pacietn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pacietn);
        }

        // GET: Pacietns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pacietn pacietn = db.pacienti.Find(id);
            if (pacietn == null)
            {
                return HttpNotFound();
            }
            return View(pacietn);
        }

        // POST: Pacietns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pacietn pacietn = db.pacienti.Find(id);
            db.pacienti.Remove(pacietn);
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
