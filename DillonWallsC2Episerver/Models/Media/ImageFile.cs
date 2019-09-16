using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace DillonWallsC2Episerver.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "2bf0a5cb-e457-4081-8ae2-1e278a5b43e9", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]

    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}