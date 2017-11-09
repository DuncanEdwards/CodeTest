using AttributeRouting;
using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTests.Controllers
{

    [RoutePrefix("invitationdigital")]
    public class InvitationController : Controller
    {
        [Route("tests/{id}")]
        public ActionResult Tests(string id)
        {
            ViewBag.Id = id;
            return View();
        }


    }
}