using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppModelv2_WebApp_OpenIDConnect_DotNet.Controllers
{
	[Authorize]
	public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

		[AllowAnonymous]
		public ActionResult OpenRoute()
		{
			return View();
		}
	}
}