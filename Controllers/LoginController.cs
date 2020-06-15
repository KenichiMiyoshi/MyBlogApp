using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBlogApp.Models;

namespace MyBlogApp.Controllers
{
    //誰でもアクセスできるようにする
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //認証に使うmembershipProviderのインスタンスを保持
        readonly private CustomMembershipProvider membershipProvider = new CustomMembershipProvider();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}