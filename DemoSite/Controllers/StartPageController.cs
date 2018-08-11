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
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(IContentLoader loader) : base(loader) { }
        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}