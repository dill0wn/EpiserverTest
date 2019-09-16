using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DillonWallsC2Episerver.Models.Blocks
{
    [ContentType(DisplayName = "HeaderBlock", GUID = "23c58954-3f8a-4599-997c-234226cfbdeb", Description = "")]
    public class HeaderBlock : BlockData
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
    }
}