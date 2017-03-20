using APMT_D.o.T_Team.Areas.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APMT_D.o.T_Team.Areas.User.Code;

namespace APMT_D.o.T_Team.Areas.User.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: User/User
        [HttpGet]
        public ActionResult Log_In()
        {
            return View();
        }
        //public ActionResult Log_In(LoginModel model)
        //{
        //    var result = new UserModel().Login(model.Email, model.Password);
        //    if(result && ModelState.IsValid)
        //    {
        //        SessionHelper.SetSession(new UserSession() {Email =model.Email });
        //        return RedirectToAction("View_List", "ProductAdministratorManagement",new {area="System" });
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "The email or password is incorrect.");
        //    }
        //    return View(model);
        //}
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Forgot_password()
        {
            return View();
        }
        public ActionResult View_Details()
        {
            return View();
        }
    }
}