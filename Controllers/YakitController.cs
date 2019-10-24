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
    public class YakitController : Controller
    {
        private G302Context db = new G302Context();
        // GET: Yakit
        public ActionResult Index()
        {
            return View(db.yYakitTipis.ToList());
        }

        public ActionResult Create()
        {
            var yakit = new yYakitTipi();
            ViewBag.YakitId = new SelectList(db.yVites, "Id", "Yakıt");
            return View(yakit);
        }
        [HttpPost]
        public ActionResult Create(yYakitTipi yakit)
        {
            if (ModelState.IsValid)
            {
                db.yYakitTipis.Add(yakit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yakit);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yYakitTipi yakit = db.yYakitTipis.Find(id);
            if (yakit == null)
            {
                return HttpNotFound();
            }

            ViewBag.YakitId = new SelectList(db.yVites, "Id", "Vites", yakit.Id);
            return View(yakit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(yYakitTipi yakit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yakit).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yakit);
        }
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yYakitTipi yakit = await db.yYakitTipis.FindAsync(id);
            if (yakit == null)
            {
                return HttpNotFound();
            }
            return View(yakit);
        }
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            yYakitTipi yakit = await db.yYakitTipis.FindAsync(id);
            if (yakit == null)
            {
                return HttpNotFound();
            }
            return View(yakit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            yYakitTipi yakit = await db.yYakitTipis.FindAsync(id);
            db.yYakitTipis.Remove(yakit);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}