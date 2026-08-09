using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSIT_02.Controllers
{//後台會員列表搜尋、調整會員角色(role)
    public class MemberAdminController : Controller
    {
        // GET: MemberAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}