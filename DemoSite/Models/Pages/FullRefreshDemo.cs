using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "FullRefreshDemo", 
        GUID = "5bedbf88-dbe6-427a-adae-fa5deec1d920",
        Description = "Testing Full Refresh")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class FullRefreshDemo : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main " +
            "content area of the page, using the XHTML-editor you can " +
            "insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(Name = "Show Banner", 
            Description = "Use to set display of banner property.",
            GroupName = SystemTabNames.Content, Order = 20)]
        public virtual bool ShowBanner { get; set; }

        [Display(Name = "Banner Text", 
            Description = "Text to show in banner.",
            GroupName = SystemTabNames.Content, Order = 30)]
        public virtual string BannerText { get; set; }

    }
}