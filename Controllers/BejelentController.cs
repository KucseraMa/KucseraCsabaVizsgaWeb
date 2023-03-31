using KucseraCsabaVizsgaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace KucseraCsabaVizsgaWeb.Controllers
{
    public class BejelentController : Controller
    {
        public IActionResult Index()
        {
            string cime = Request.Form["cim"];

            BejelentModel bm = new();
            bm.AktualisIdo = DateTime.Now;
            bm.Sorszam = 1;
            bm.Cime = cime;

            return View(bm);
        }
    }
}
