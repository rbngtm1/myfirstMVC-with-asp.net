using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstMVC.Models;

namespace firstMVC.Controllers
{
    public class SummerController : Controller
    {
        // GET: Summer
        public ActionResult Index()
        {
            List<Summer> summerList = new List<Summer>();

            Summer summer = new Models.Summer();
            summer.SummerEvent = "Italian Festival";
            summer.SummerLocation = "Wilmington, DE";
            summer.SummerYear = 2018;
            summer.Active = true;
            summer.ImageURL = "/Content/Images/italian.jpg";
            summerList.Add(summer);

            summer = new Models.Summer();
            summer.SummerEvent = "Greek Festival";
            summer.SummerLocation = "Wilmington, DE";
            summer.SummerYear = 2018;
            summer.Active = true;
            summer.ImageURL = "/Content/Images/greek.jpg";
            summerList.Add(summer);

            summer = new Models.Summer();
            summer.SummerEvent = "Polish Festival";
            summer.SummerLocation = "Wilmington, DE";
            summer.SummerYear = 2018;
            summer.Active = true;
            summer.ImageURL = "/Content/Images/polish.jpg";
            summerList.Add(summer);


            return View(summerList);
        }
    }
}