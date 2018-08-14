﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DemoSite.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace DemoSite.Controllers
{
    public class FullRefreshDemoController : PageControllerBase<FullRefreshDemo>
    {
        public FullRefreshDemoController(IContentLoader loader) : base(loader) { }
        public ActionResult Index(FullRefreshDemo currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}