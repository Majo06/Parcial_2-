using Parcial_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial_2.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Correcto()
        {
            return View();
        }
        [HttpGet]
        public ActionResult incorrecto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(Cajero c)
        {
            if (c.Monto % 5 == 0)
            {
                return Redirect("Correcto");
            }
            else
            {
                return Redirect("incorrecto");
            }
        }
    }
}