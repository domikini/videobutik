using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videobutik.Context;
using Videobutik.Models;

namespace Videobutik.Controllers
{
    public class VideofilmController : Controller
    {
        VideofilmContext db = new VideofilmContext();
        
        // GET: Videofilm
        public ActionResult Index()
        {
            var videofilmer = db.Videofilmer.ToList();
             
            return View(videofilmer);
        }

        // GET: Videofilm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Videofilm/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Videofilm videofilm)
        {
            try
            {
                db.Videofilmer.Add(videofilm);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Orderbytitle()
        {
            var videofilmer = from v in db.Videofilmer
                              orderby v.titel descending
                              select v;

            return View(videofilmer);
        }

        public ActionResult Popular()
        {
            return View();
        }

        public ActionResult ListaVideofilmer()
        {
            List<Videofilm> listaVideofilmer = new List<Videofilm>();
            listaVideofilmer.Add(new Videofilm { titel = "Die Hard 1", speltid = 128, rating = "4.6", genre = "Action" });
            listaVideofilmer.Add(new Videofilm { titel = "Terminator 2", speltid = 179, rating = "4.9", genre = "Action" });
            listaVideofilmer.Add(new Videofilm { titel = "Hajen", speltid = 134, rating = "4.2", genre = "Skräck" });
            listaVideofilmer.Add(new Videofilm { titel = "Gudfadern", speltid = 200, rating = "4.4", genre = "Drama" });
            return View(listaVideofilmer);
        }
    }
}