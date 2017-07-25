using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_ASP_NET_Application.Models;

namespace Test_ASP_NET_Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            RegisterCustomerModel model = new RegisterCustomerModel("Dima", "Zastavnuyk", "DimaZ", "12345678", "12345678", "zastavnyk95@gmail.com", Sex.Male , "380996655322", true);
            return View(model);
        }



        [HttpPost]
        public ActionResult Create(RegisterCustomerModel incomingData)
        {
            if (incomingData.Login==incomingData.Password)
            {
                ModelState.AddModelError("", "Password and login is match");
            }
            if (!incomingData.RegistrationConsent)
            {
                ModelState.AddModelError("", "You have not confirmed the registration");
            }


            if (ModelState.IsValid)
            {

                return View("RegistrationComleted");
            }
            else { return View(); }
        }

        




        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}