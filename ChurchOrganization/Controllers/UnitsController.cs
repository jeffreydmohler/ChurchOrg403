using ChurchOrganization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChurchOrganization.Controllers
{
    public class UnitsController : Controller
    {
        public static List<Units> lstUnits = new List<Units>();
        public static List<string> lstTypes = new List<string>()
        {
            "Ward", "Stake", "Branch"
        };

        
        // GET: Units
        public ActionResult ShowUnits()
        {
            return View(lstUnits);
        }

        public ActionResult AddUnit()
        {
            ViewBag.Types = lstTypes;

            return View();
        }

        [HttpPost]
        public ActionResult AddUnit(Units newUnit)
        {
            if (ModelState.IsValid)
            {
                newUnit.unitCode = lstUnits.Count + 1;
                lstUnits.Add(newUnit);
                return RedirectToAction("ShowUnits");
            }
            else
            {
                ViewBag.Types = lstTypes;

                return View(newUnit);
            }
        }

        public ActionResult EditUnit(int iCode)
        {
            ViewBag.Types = lstTypes;

            Units oUnit = lstUnits.Find(x => x.unitCode == iCode);

            return View(oUnit);
        }

        [HttpPost]
        public ActionResult EditUnit(Units myUnit)
        {
            var obj = lstUnits.FirstOrDefault(x => x.unitCode == myUnit.unitCode);

            if (obj != null)
            {
                obj.unitName = myUnit.unitName;
                obj.unitType = myUnit.unitType;
                obj.unitLocation = myUnit.unitLocation;
            }
            return View("ShowUnits", lstUnits);
        }
    }
}