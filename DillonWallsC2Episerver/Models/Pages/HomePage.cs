using System;
using System.ComponentModel.DataAnnotations;
using DillonWallsC2Episerver.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace DillonWallsC2Episerver.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "b6bce58c-32c4-4670-aca9-73faed6feafc", Description = "")]
    public class HomePage : PageData
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
    }
}