using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "Standard Page", GUID = "c8912f66-79cb-4381-b93a-82baf7406f83",
        Description = "Use this Page Type for standard pages.", GroupName = "Normal Stuff")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}