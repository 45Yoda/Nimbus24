using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nimbus24;

namespace Nimbus24.Controllers
{
    public class PrestadorsController : Controller
    {
        private Nimbus24Context db = new Nimbus24Context();

        // GET: Prestadors
        public ActionResult Index()
        {
            var prestador = db.Prestador.Include(p => p.Cidade);
            return View(prestador.ToList());
        }

        // GET: Prestadors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestador.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            return View(prestador);
        }

        // GET: Prestadors/Create
        public ActionResult Create()
        {
            ViewBag.Cidade_cidade = new SelectList(db.Cidade, "Cidade1", "Cidade1");
            return View();
        }

        // POST: Prestadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nome,mail,rating,password,contacto,Cidade_cidade")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                db.Prestador.Add(prestador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cidade_cidade = new SelectList(db.Cidade, "Cidade1", "Cidade1", prestador.Cidade_cidade);
            return View(prestador);
        }

        // GET: Prestadors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestador.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cidade_cidade = new SelectList(db.Cidade, "Cidade1", "Cidade1", prestador.Cidade_cidade);
            return View(prestador);
        }

        // POST: Prestadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,mail,rating,password,contacto,Cidade_cidade")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cidade_cidade = new SelectList(db.Cidade, "Cidade1", "Cidade1", prestador.Cidade_cidade);
            return View(prestador);
        }

        // GET: Prestadors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestador prestador = db.Prestador.Find(id);
            if (prestador == null)
            {
                return HttpNotFound();
            }
            return View(prestador);
        }

        // POST: Prestadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Prestador prestador = db.Prestador.Find(id);
            db.Prestador.Remove(prestador);
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
