using KucseraCsabaVizsgaWeb.Model;
using KucseraCsabaVizsgaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KucseraCsabaVizsgaWeb.Controllers
{
    public class BejelentController : Controller
    {

        public IActionResult Index()
        {
            string cime = Request.Form["cim"];
            string iranyszama = Request.Form["iranyszam"];
            string varosa = Request.Form["varos"];

            BejelentModel bm = new();
            bm.AktualisIdo = DateTime.Now;
            bm.Cime = cime;
            bm.Iranyszam = iranyszama;
            bm.Varos = varosa;

            try
            {
                var newItem = new Bejelento2 { Cim = bm.Cime, Date = bm.AktualisIdo, Iranyszam = bm.Iranyszam, Varos = bm.Varos };
                var Ab = new Adatbazis();
                Ab.Bejelento2s.Add(newItem);
                Ab.SaveChanges();

                return View(bm);
            }
            catch (Exception e)
            {

                return View(e);
            }
            
        }
    }
}
