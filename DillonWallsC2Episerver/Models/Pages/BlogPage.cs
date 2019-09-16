using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace DillonWallsC2Episerver.Models.Pages
{
    [ContentType(DisplayName = "BlogPage", GUID = "492886fa-ca61-4691-9ba1-03d57bc173f9", Description = "")]
    public class BlogPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "BannerImage",
            Description = "The page Banner Image",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BannerImage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The page Title",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "SubTitle",
            Description = "The page SubTitle",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual String SubTitle { get; set; }

        // TODO: Author - way to data-ify that??
        // TODO: date - way to use date picker??

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}