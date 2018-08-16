using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "PropertyFor Test", GUID = "29fcb2f0-4bc0-4a34-9439-e2ee4a4d909f", Description = "")]
    [AvailableContentTypes(IncludeOn = new[] { typeof(StartPage) })]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class PropertyForPageTest : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [UIHint("CustomString")]
        public virtual string CustomizedString { get; set; }
    }
}