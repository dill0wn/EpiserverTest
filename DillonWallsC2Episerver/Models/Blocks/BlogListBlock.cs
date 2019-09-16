using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DillonWallsC2Episerver.Models.Blocks
{
    [ContentType(DisplayName = "BlogListBlock", GUID = "0bdbbbaa-56c9-429a-8861-084997fe4f53", Description = "")]
    public class BlogListBlock : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */

        [Display(GroupName = SystemTabNames.Content)]
        [Required]
        public virtual PageReference RootPage { get; set; }

        [Display(GroupName = SystemTabNames.Content)]
        public virtual PageType PageTypeFilter { get; set; }

        [Display(GroupName = SystemTabNames.Content)]
        public virtual int Count { get; set; }
    }
}