using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SwinnyVetServiceAPImkII.Models;
using SwinnyVetServiceAPImkII.ViewModels;

namespace SwinnyVetServiceAPImkII.Controllers
{
    public class ProceduresController : Controller
    {
        private SwinnyVetSeviceEntities db = new SwinnyVetSeviceEntities();

        // GET: Procedures
        public ActionResult Index(int? procedureID, int? treatmentID)
        {
            var viewModel = new ProcedureIndexData();
            viewModel.Procedures = db.Procedures
                //.Include(p => p.Treatments.Select(t => t.Owner))
                .OrderBy(p => p.ProcedureID);

            if (procedureID != null)
            {
                ViewBag.ProcedureID = procedureID.Value;
                viewModel.Treatments = viewModel.Procedures.Where(
                    p => p.ProcedureID == procedureID.Value).Single().Treatments;
            }
            return View(viewModel);
        }

        // GET: Procedures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procedure procedure = db.Procedures.Find(id);
            if (procedure == null)
            {
                return HttpNotFound();
            }
            return View(procedure);
        }

        public ActionResult Treatments(int? id)
        {
            var treatments = db.Treatments.Include(b => b.Owner).Include(b => b.Procedure);
            if (treatments == null)
            {
                return HttpNotFound();
            }
            treatments = treatments.Where(x => x.ProcedureID == id);
            return View(treatments.ToList());
        }

        // GET: Procedures/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Procedures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProcedureID,Description,Price")] Procedure procedure)
        {
            if (ModelState.IsValid)
            {
                db.Procedures.Add(procedure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(procedure);
        }

        // GET: Procedures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procedure procedure = db.Procedures.Find(id);
            if (procedure == null)
            {
                return HttpNotFound();
            }
            return View(procedure);
        }

        // POST: Procedures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProcedureID,Description,Price")] Procedure procedure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(procedure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(procedure);
        }

        // GET: Procedures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Procedure procedure = db.Procedures.Find(id);
            if (procedure == null)
            {
                return HttpNotFound();
            }
            return View(procedure);
        }

        // POST: Procedures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Procedure procedure = db.Procedures.Find(id);
            db.Procedures.Remove(procedure);
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
