using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSIT_02.Controllers
{//跨多張表整合(個人資料+進度+成就+標籤)
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
    }
}