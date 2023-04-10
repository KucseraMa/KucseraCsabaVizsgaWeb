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

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kucsera\source\repos\KucseraCsabaVizsgaWeb\Adatbazis\Bejelent.mdf;Integrated Security=True;Connect Timeout=30");

            //string cmdstring = "Insert into Bejelento2 (Varos, Cim, Iranyszam, Date) VALUES (@Varos, @Cim, @Iranyszam, @Date)";


            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = cmdstring;
            //cmd.Connection = con;

            //cmd.Parameters.AddWithValue("@Varos", bm.Varos);
            //cmd.Parameters.AddWithValue("@Cim", bm.Cime);
            //cmd.Parameters.AddWithValue("@Iranyszam", bm.Iranyszam);
            //cmd.Parameters.AddWithValue("@Date", bm.AktualisIdo);


            //try
            //{
            //    con.Open();

            //    int i = cmd.ExecuteNonQuery();

            //    con.Close();

            //    if (i != 0)
            //    {
            //        // error handling;   
            //    }
            //    return View(bm);
            //}
            //catch (Exception e)
            //{

            //   return View(e);
            //}      
        }
    }
}
