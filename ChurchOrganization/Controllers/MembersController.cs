using ChurchOrganization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChurchOrganization.Controllers
{
    public class MembersController : Controller
    {
        public static List<Members> lstMembers = new List<Members>();

        // GET: Members
        public ActionResult ShowMembers()
        {
            return View(lstMembers);
        }

        public ActionResult AddMember()
        {
            ViewBag.ListCallings = CallingsController.lstCallings;
            ViewBag.ListUnits = UnitsController.lstUnits;

            return View();
        }

        [HttpPost]
        public ActionResult AddMember(Members newMember)
        {
            if (ModelState.IsValid)
            {
                lstMembers.Add(newMember);
                return RedirectToAction("ShowMembers");
            }
            else
            {
                ViewBag.ListCallings = CallingsController.lstCallings;
                ViewBag.ListUnits = UnitsController.lstUnits;

                return View(newMember);
            }
        }

        public ActionResult EditMember(int iCode)
        {
            Members oMember = lstMembers.Find(x => x.membershipNumber == iCode);

            return View(oMember);
        }

        [HttpPost]
        public ActionResult EditMember(Members myMember)
        {
            var obj = lstMembers.FirstOrDefault(x => x.membershipNumber == myMember.membershipNumber);

            if (obj != null)
            {
                obj.fName = myMember.fName;
                obj.lName = myMember.lName;
                obj.email = myMember.email;
                obj.unitName = myMember.unitName;
                obj.callingName = myMember.callingName;
            }
            return View("ShowMembers", lstMembers);
        }
    }
}