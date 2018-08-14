using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DemoSite.Models.Pages;
using DemoSite.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace DemoSite.Controllers
{
    public class FullRefreshDemoPartialController : PartialContentController<FullRefreshDemo>
    {
        public override ActionResult Index(FullRefreshDemo currentPage)
        {
            return PartialView(PageViewModel.Create(currentPage));
        }
    }
}