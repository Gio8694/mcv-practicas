using Noticiero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Noticiero.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var InfoEntradas = db.Database.SqlQuery<NoticiasXClasif>(@"Select B.NoticiaID,B.ClasifID,B.Titulo,B.Contenido,B.Autor,B.FechaNoticia,B.Foto,A.Nombre 
                                                                    From Clasifs A Inner Join Noticias B On (A.ClasifID=B.ClasifID) order by FechaNoticia Desc").Take(10).ToList();
            return View(InfoEntradas);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}