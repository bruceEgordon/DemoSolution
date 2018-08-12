using System;
using System.ComponentModel.DataAnnotations;
using DemoSite.Business.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "My content type", GUID = "f63cfd40-1882-490b-a3ac-b9cd8ae99966",
        Description = "Description for this content type", Order = 1024, GroupName = "My group")]
    [Access(Users = "Bubba", Roles = "CmsEditors")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-page.jpg")]
    public class TypedPageWithAttributeSample : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [SelectOne(SelectionFactoryType = typeof (WorkStatusSelectionFactory))]
        public virtual string WorkStatus { get; set; }

    }
}