using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DemoSite.Models.Blocks
{
[ContentType(DisplayName = "Editorial", 
    GUID = "96404662-18c9-42c6-a8b4-345770eb583f", 
    Description = "Reusable rich ediorial text.")]
[ImageUrl("~/Static/contenticons/epi-edu-icon-block.jpg")]
public class EditorialBlock : BlockData
{

    [CultureSpecific]
    [Display(
        Name = "Main body",
        Description = "Main body with rich XHTML-editor",
        GroupName = SystemTabNames.Content,
        Order = 10)]
    public virtual XhtmlString MainBody { get; set; }

}
}