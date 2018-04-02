using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videobutik.Context;
using Videobutik.Models;

namespace Videobutik.Controllers
{
    public class KundController : Controller
    {
        KundContext db = new KundContext(); 
        
        // GET: Kund
        public ActionResult Index()
        {
            var kunder = db.Kunder.ToList();
            return View(kunder);
        }

        // GET: Kund/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kund/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kund/Create
        [HttpPost]
        public ActionResult Create(Kund kund)
        {
            try
            {
                db.Kunder.Add(kund);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Orderbydate()
        {
            var kunder = db.Kunder.OrderBy(k => k.registerdatum);
            return View(kunder);
        }

        // GET: Kund/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kund/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kund/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kund/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
