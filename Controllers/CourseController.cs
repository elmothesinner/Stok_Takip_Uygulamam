using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult DepolarAdmın()
        {
            var model = Repository.Applications;
            return View(model);
        }
         public IActionResult DepolarUye()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult DepoKayıt()
        {
        return View();
        }


        public IActionResult Indexadmin()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult adnan()
        {
            return View();
        }
        public IActionResult Üyegiriş()
        {
            return View();
        }
        public IActionResult adminIndex()
        {   var applicationList = ResopA.Applications;
            var adminmodel=new Admin{
                adminİsim="zamzuma",
                adminPass=1234,
                Email="ahmetburakcif@gmail.com"

            };
            return View(adminmodel);
        }
        public IActionResult UyeIndex()
        {       
                var Umodel=new Uye{
                Uname="yenimüsterigümrüksever",
                UPass=1234,
                UMail="ahmetburakcif@gmail.com"

            };
            return View(Umodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            //if(Repository.Applications.Any(c => c.ÜrünAd.Equals(model.ÜrünAd)))
            {
                //ModelState.AddModelError("","There is already an application for you.");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();
        }
        

    }
    /*public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }
*/
}