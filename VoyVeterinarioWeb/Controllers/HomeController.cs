using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VoyVeterinarioWeb.Models;

namespace VoyVeterinarioWeb.Controllers
{
    public class HomeController : Controller
    {
        private VoyVeterinarioWeb.Models.VoyVeterinarioEntities db = new VoyVeterinarioEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Listado(string tipo)
        {
            var listado = db.Directorios.ToList();

            if (tipo=="URGENCIAS")
            {

            }

            
            
            return View(listado);
        }

        public ActionResult ByPass()
        {
            return View();
        }

        public ActionResult Detalles(int Id)
        {
            return View();
        }

    }
}