using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilm.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hata404()
        {
            return View();
        }

        public ActionResult Fragmanlar()
        {
            return View();
        }

        [Authorize(Roles="Admin,Edito")] //sadece giriş yapanlargirebilsin

       // [Authorize(Users="d@d")]  sadece belirtilen kullanıcı girebilsin
        public ActionResult Filmekle()
        {
            return View();
        }
        public ActionResult Iletisim()
        {
            return View();
        }
        //404: hata404
        //trailers_page :Fragmanlar
        //contacts : Iletisim

        //301, 302: yönlendirme
    }
}