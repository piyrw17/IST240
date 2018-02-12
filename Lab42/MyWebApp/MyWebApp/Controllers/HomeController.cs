using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult CalcApp()
        {
            ViewBag.Message = "MyCalcApp";
           


            return View();       

    }
        [HttpPost]
        public ActionResult CalcApp(string NumberA, string NumberB, string Function)
        {
            int Answer = 0;


            int Number1 = Convert.ToInt32(NumberA);
            int Number2 = Convert.ToInt32(NumberB);            

            switch (Function)
            {
                case "Addition":
                    Answer = Number1 + Number2;
                    break;

                case "Subtraction":
                    Answer = Number1 - Number2;
                    break;

                case "Division":
                    Answer = Number1 / Number2;
                    break;

                case "Multiplication":
                    Answer = Number1 * Number2;
                    break;

                default:
                    break;
            }


            return View("CalcApp", (object)Answer.ToString());
        }
    }
    
}