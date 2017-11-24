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
            //Home home = context.HomeFactory.Get(1);
            Subpage home = context.SubpageFactory.Get(1);
            return View(home);
        }

        public ActionResult Deconstruction()
        {
            Subpage deconstruction = context.SubpageFactory.Get(2);
            return View(deconstruction);
        }

        public ActionResult Crushing()
        {
            Subpage crushing = context.SubpageFactory.Get(3);
            return View(crushing);
        }

        public ActionResult Environment()
        {
            Subpage environment = context.SubpageFactory.Get(4);
            return View(environment);
        }

        public ActionResult Contact()
        {
            Contact contact = context.ContactFactory.Get(1);
            return View(contact);
        }
    }
}