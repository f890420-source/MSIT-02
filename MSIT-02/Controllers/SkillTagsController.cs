using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSIT_02.Data;
using MSIT_02.Models.Entities;

namespace MSIT_02.Controllers
{
    public class SkillTagsController : Controller
    {
        private MSIT_02Context db = new MSIT_02Context();

        // GET: SkillTags
        public ActionResult Index()
        {
            return View(db.SkillTags.ToList());
        }

        // GET: SkillTags/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillTag skillTag = db.SkillTags.Find(id);
            if (skillTag == null)
            {
                return HttpNotFound();
            }
            return View(skillTag);
        }

        // GET: SkillTags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkillTags/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TagId,Category,TagName,ParentTagId,UnlockCondition")] SkillTag skillTag)
        {
            if (ModelState.IsValid)
            {
                db.SkillTags.Add(skillTag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skillTag);
        }

        // GET: SkillTags/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillTag skillTag = db.SkillTags.Find(id);
            if (skillTag == null)
            {
                return HttpNotFound();
            }
            return View(skillTag);
        }

        // POST: SkillTags/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TagId,Category,TagName,ParentTagId,UnlockCondition")] SkillTag skillTag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skillTag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skillTag);
        }

        // GET: SkillTags/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkillTag skillTag = db.SkillTags.Find(id);
            if (skillTag == null)
            {
                return HttpNotFound();
            }
            return View(skillTag);
        }

        // POST: SkillTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SkillTag skillTag = db.SkillTags.Find(id);
            db.SkillTags.Remove(skillTag);
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
