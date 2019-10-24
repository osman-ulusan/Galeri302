using Galeri302.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Galeri302.Controllers
{
    public class VitesController : Controller
    {
        private G302Context db = new G302Context();
        // GET: Vites
        public ActionResult Index()
        {
            return View(db.yVites.ToList());
        }
        public ActionResult Create()
        {
            var Vitesler = new yVites();
            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites");
            return View(Vitesler);
        }
        [HttpPost]
        public ActionResult Create(yVites Vitesler)
        {
            if (ModelState.IsValid)
            {
                db.yVites.Add(Vitesler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Vitesler);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites Vitesler = db.yVites.Find(id);
            if (Vitesler == null)
            {
                return HttpNotFound();
            }

            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites", Vitesler.Id);
            return View(Vitesler);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(yVites Vitesler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Vitesler).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Vitesler);
        }
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites Vitesler = await db.yVites.FindAsync(id);
            if (Vitesler == null)
            {
                return HttpNotFound();
            }
            return View(Vitesler);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yVites Vitesler = await db.yVites.FindAsync(id);
            if (Vitesler == null)
            {
                return HttpNotFound();
            }
            return View(Vitesler);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            yVites Vitesler = await db.yVites.FindAsync(id);
            db.yVites.Remove(Vitesler);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}