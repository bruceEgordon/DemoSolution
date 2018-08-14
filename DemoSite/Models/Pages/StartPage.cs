using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "Start Page", GUID = "2e595bed-e770-44c2-86dc-7b930d8a6421",
        Description = "Use this to create the starting page for the site.", GroupName = "Specialized")]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage), typeof(TypedPageWithAttributeSample), typeof(FullRefreshDemo) })]
    public class StartPage : PageData
    {
        [UIHint("h1")]
        [CultureSpecific]
        [Display(Name = "Heading", Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(GroupName = SiteTabNames.Contact)]
        public virtual string Phone { get; set; }

        [Display(Name = "Main Conent Area",
            Order = 40)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}