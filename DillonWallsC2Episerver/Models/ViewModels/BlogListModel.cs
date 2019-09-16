using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DillonWallsC2Episerver.Models.ViewModels
{
    public class BlogListModel
    {
        public IEnumerable<PageData> Posts { get; set; }
    }
}