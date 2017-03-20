using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APMT_D.o.T_Team.Areas.Company.Controllers
{
    public class AdministratorManagementController : Controller
    {
        // GET: Company/AdministratorManagement
        public ActionResult View_List()
        {
            return View();
        }
        public ActionResult Add_New()
        {
            return View();
        }
    }
}