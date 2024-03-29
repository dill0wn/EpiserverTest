﻿using System;
using System.ComponentModel.DataAnnotations;
using DillonWallsC2Episerver.Models.Blocks;
using DillonWallsC2Episerver.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace DillonWallsC2Episerver.Models.Pages
{



    [ContentType(DisplayName = "GeneralPage", GUID = "af9ea3a9-2fa0-4acd-b9cd-d220377e99ef", Description = "")]
    public class GeneralPage : BasePageData
    {
        [Display(
            Name = "Header",
            Description = "The page Header Block",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        //[UIHint(UIHint.Block)]
        [AllowedTypes(new[] { typeof(HeaderBlock) })]
        public virtual ContentReference Header { get; set; }

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


        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}