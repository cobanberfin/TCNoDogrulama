using Dogrulama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dogrulama.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi

        public KisiRepository rep = new KisiRepository();
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kisi kisi,string Tc)
        {
            if (rep.Check(kisi,Tc))
            {                        
                byte[] tchash, tcsalt;
                rep.CreateTcHash(Tc, out tchash, out tcsalt);
                kisi.tchash = tchash;
                kisi.tcsalt = tcsalt;
                rep.CreatUser(kisi);
            }
            else
            {
                return HttpNotFound();
            }
                return Content("kullanıcı eklendı");


        }
    }
}