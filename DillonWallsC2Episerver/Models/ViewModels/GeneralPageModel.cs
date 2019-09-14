using DillonWallsC2Episerver.Models.Blocks;
using EPiServer.Core;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DillonWallsC2Episerver.Models.ViewModels
{
    public class GeneralPageModel
    {
        public HeaderBlock Header { get; set; }

        [UIHint(UIHint.Image)]
        public ContentReference BannerImage { get; set; }

        public String Title { get; set; }

        public String SubTitle { get; set; }

        public XhtmlString MainBody { get; set; }

    }
}