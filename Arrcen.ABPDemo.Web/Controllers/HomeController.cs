﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Arrcen.ABPDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}