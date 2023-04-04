using KucseraCsabaVizsgaWeb.Model;
using KucseraCsabaVizsgaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace KucseraCsabaVizsgaWeb.Controllers
{
    public class BejelentController : Controller
    {
        
        public IActionResult Index()
        {
          //  Adatbazis ab = new();
            

            string cime = Request.Form["cim"];
           string iranyszama = Request.Form["iranyszam"];
            string varosa = Request.Form["varos"];            

            BejelentModel bm = new();
            bm.AktualisIdo = DateTime.Now;
            bm.Sorszam = 1;
            bm.Cime = cime;
            bm.Iranyszam = iranyszama;
            bm.Varos = varosa;

            return View(bm);
        }
    }
}
