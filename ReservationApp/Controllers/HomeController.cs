using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservationApp.Models;

namespace ReservationApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repository = new ReservationRepository();
            var reservations = repository.AllReservations();
            ViewBag.reservations = reservations.Count();
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
    }
}