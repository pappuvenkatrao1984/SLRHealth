using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using ResourceModel;

namespace HealthCare.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //OutPatientController cntOutPatientController = new OutPatientController();
            //OutPatient patient = new OutPatient();

            //cntOutPatientController.GenerateOpNumber(patient);
            ViewBag.Title = "Home Page";

            return View();
            
        }
    }
}
