using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.classes;
using Antlr.Runtime;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Skills.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniYetenek(Skill y)
        {
            c.Skills.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var deger = c.Skills.Find(id);
            c.Skills.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var deger = c.Skills.Find(id);
            return View("YetenekGuncelle", deger);
        }
        [HttpPost]
        public ActionResult YetenekGuncelle(Skill x)
        {
            var deger = c.Skills.Find(x.ID);
            deger.Explanation = x.Explanation;
            deger.Value = x.Value;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}