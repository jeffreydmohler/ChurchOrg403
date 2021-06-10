using ChurchOrganization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChurchOrganization.Controllers
{
    public class CallingsController : Controller
    {
        public static List<Callings> lstCallings = new List<Callings>()
        {
            new Callings{ callingCode = 1, callingName = "President", callingOrganization = "Elder's Quorum" },
            new Callings{ callingCode = 2, callingName = "President", callingOrganization = "Relief Society" },
            new Callings{ callingCode = 3, callingName = "Bishop", callingOrganization = "Bishopric" },
        };
        public static List<string> lstOrganizations = new List<string>()
        {
            "Bishopric", "Relief Society", "Elder's Quorum", "Primary", "Sunday School", "High Council", "Young Men", "Young Women"
        };

        // GET: Callings
        public ActionResult ShowCallings()
        {
            return View(lstCallings);
        }

        public ActionResult AddCalling()
        {
            ViewBag.Organizations = lstOrganizations;

            return View();
        }

        [HttpPost]
        public ActionResult AddCalling(Callings newCalling)
        {
            if (ModelState.IsValid)
            {
                newCalling.callingCode = lstCallings.Count() + 1;
                lstCallings.Add(newCalling);
                return RedirectToAction("ShowCallings");
            }
            else
            {
                ViewBag.Organizations = lstOrganizations;

                return View(newCalling);
            }
        }

        public ActionResult EditCalling(int iCode)
        {
            ViewBag.Organizations = lstOrganizations;

            Callings oCalling = lstCallings.Find(x => x.callingCode == iCode);

            return View(oCalling);
        }

        [HttpPost]
        public ActionResult EditCalling(Callings myCalling)
        {
            var obj = lstCallings.FirstOrDefault(x => x.callingCode == myCalling.callingCode);

            if (obj != null)
            {
                obj.callingName = myCalling.callingName;
                obj.callingOrganization = myCalling.callingOrganization;
            }
            return View("ShowCallings", lstCallings);
        }
    }
}