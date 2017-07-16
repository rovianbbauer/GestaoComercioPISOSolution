using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestaoComercioPISO.WebSite.Models;

namespace GestaoComercioPISO.WebSite.Controllers
{
    public class ClientesRovianController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ClientesRovian
        public ActionResult Index()
        {
            return View(db.ClienteRovian.ToList());
        }

        // GET: ClientesRovian/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteRovian clienteRovian = db.ClienteRovian.Find(id);
            if (clienteRovian == null)
            {
                return HttpNotFound();
            }
            return View(clienteRovian);
        }

        // GET: ClientesRovian/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesRovian/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeCompletoRazaoSocial,ApelidoNomeFantasia,CPFCNPJ")] ClienteRovian clienteRovian)
        {
            if (ModelState.IsValid)
            {
                clienteRovian.Id = Guid.NewGuid();
                db.ClienteRovian.Add(clienteRovian);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteRovian);
        }

        // GET: ClientesRovian/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteRovian clienteRovian = db.ClienteRovian.Find(id);
            if (clienteRovian == null)
            {
                return HttpNotFound();
            }
            return View(clienteRovian);
        }

        // POST: ClientesRovian/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeCompletoRazaoSocial,ApelidoNomeFantasia,CPFCNPJ")] ClienteRovian clienteRovian)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteRovian).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteRovian);
        }

        // GET: ClientesRovian/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteRovian clienteRovian = db.ClienteRovian.Find(id);
            if (clienteRovian == null)
            {
                return HttpNotFound();
            }
            return View(clienteRovian);
        }

        // POST: ClientesRovian/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ClienteRovian clienteRovian = db.ClienteRovian.Find(id);
            db.ClienteRovian.Remove(clienteRovian);
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
