using LoanSimulation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanSimulation.Controllers
{
    public class HomeController : Controller
    {

        private simulationEntities1 db = new simulationEntities1();
        private static List<simulation> simuls = new List<simulation>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Simulation()
        {
            ViewBag.result = simuls;
            return View();
        }

        [HttpPost]
        public ActionResult Simulation(simulation simul)
        {
            simul.payment = simul.amount * simul.rate;
            Debug.WriteLine(simul.id+" "+simul.amount+" "+simul.rate+" "+simul.gender);
            
            simuls.Add(simul);
            ViewBag.result = simuls;
            
            try
            {
                db.simulations.Add(simul);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            
            return View();
        }
    }
}