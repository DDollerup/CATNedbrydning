using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CATNedbrydning_.Factories;
using CATNedbrydning_.Models;

namespace CATNedbrydning_.Controllers
{
    public class HomeController : Controller
    {
        DBContext context = new DBContext();

        // GET: Home
        public ActionResult Index()
        {
            Home home = context.HomeFactory.Get(1);
            return View(home);
        }

        public ActionResult Crushing()
        {
            return View();
        }

        public ActionResult Contact()
        {
            Contact contact = context.ContactFactory.Get(1);
            return View(contact);
        }
    }
}