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
    public class AraclarController : Controller
    {
        private G302Context db = new G302Context();
        // GET: Araclar
        public ActionResult Index()
        {
            return View(db.Araclars.ToList());
        }
        public ActionResult Create()
        {
            var araclar = new Araclar();
            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites");
            ViewBag.YakitTipiId = new SelectList(db.yYakitTipis, "Id", "YTipi");
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Sehir");
            return View(araclar);
        }
        [HttpPost]
        public ActionResult Create(Araclar araclar, IEnumerable<HttpPostedFileBase>ResimDosya)
        {
            if (ModelState.IsValid)
            {
                if (ResimDosya!=null)
                {
                    foreach (var item in ResimDosya)
                    {
                        item.SaveAs(Server.MapPath($"~/Content/images/{item.FileName}"));
                        araclar.Foto = "/Content/images/" + item.FileName;
                    }
                }
                araclar.dateTime = DateTime.Now;
                araclar.SaveUser = -1;
                araclar.UpdateDate = DateTime.Now;
                araclar.UpdateUser = -1;
                db.Araclars.Add(araclar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites",araclar.VitesId);
            ViewBag.YakitTipiId = new SelectList(db.yYakitTipis, "Id", "YTipi",araclar.YakitTipiId);
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Sehir",araclar.SehirId);

            return View(araclar);
        }
        public ActionResult Edit (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Araclar araclar = db.Araclars.Find(id);
            if (araclar == null)
            {
                return HttpNotFound();
            }

            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites", araclar.VitesId);
            ViewBag.YakitTipiId = new SelectList(db.yYakitTipis, "Id", "YTipi", araclar.YakitTipiId);
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Sehir", araclar.SehirId);
            return View(araclar);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Araclar araclar)
        {
            if (ModelState.IsValid)
            {
                araclar.UpdateDate = DateTime.Now;
                araclar.UpdateUser = -1;
                db.Entry(araclar).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VitesId = new SelectList(db.yVites, "Id", "Vites", araclar.VitesId);
            ViewBag.YakitTipiId = new SelectList(db.yYakitTipis, "Id", "YTipi", araclar.YakitTipiId);
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Sehir", araclar.SehirId);
            return View(araclar);
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Araclar araclar = await db.Araclars.FindAsync(id);
            if (araclar == null)
            {
                return HttpNotFound();
            }
            return View(araclar);
        }

        public async Task<ActionResult>Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Araclar araclar = await db.Araclars.FindAsync(id);
            if (araclar == null)
            {
                return HttpNotFound();
            }
            return View(araclar);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult>Delete(int id)
        {
            Araclar araclar = await db.Araclars.FindAsync(id);
            db.Araclars.Remove(araclar);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}