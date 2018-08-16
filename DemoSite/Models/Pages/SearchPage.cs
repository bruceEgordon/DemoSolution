using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoSite.Models.Pages
{
    [ContentType(DisplayName = "Search", GUID = "9ce5b4b8-a4a9-4883-886a-9bfd6b0bb49a",
        Description = "Used for searching content.", GroupName = "Specialized")]
    [ImageUrl("~/Static/contenticons/epi-edu-icon-search.jpg")]
    public class SearchPage : StandardPage
    {
    }
}