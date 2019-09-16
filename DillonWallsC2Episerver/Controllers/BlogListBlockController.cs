using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DillonWallsC2Episerver.Models.Blocks;
using DillonWallsC2Episerver.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace DillonWallsC2Episerver.Controllers
{
    public class BlogListBlockController : BlockController<BlogListBlock>
    {
        public override ActionResult Index(BlogListBlock currentBlock)
        {
            //var pages = FindBlogPosts(currentBlock);

            //// sort pages
            //pages = Sort(pages);

            //if (currentBlock.Count > 0)
            //{
            //    pages = pages.Take(currentBlock.Count);
            //}

            //var model = new BlogListModel
            //{
            //    Posts = pages
            //};



            var model = new BlogListModel
            {
                Posts = new List<PageData>()
            };

            return PartialView(model);
        }

        private IEnumerable<PageData> FindBlogPosts(BlogListBlock currentBlock)
        {
            IEnumerable<PageData> pages;
            var listRoot = currentBlock.RootPage;

            var repo = ServiceLocator.Current.GetInstance<IContentLoader>();

            if (currentBlock.PageTypeFilter != null)
            {
                pages = repo.GetChildren<PageData>(listRoot)
                    .Where(p => p.ContentTypeID == currentBlock.PageTypeFilter.ID);
            }
            else
            {
                pages = repo.GetChildren<PageData>(listRoot);
            }

            // TODO: Add filter to hide unpublished pages and apply access control. 


            return pages;
        }



        private IEnumerable<PageData> Sort(IEnumerable<PageData> pages)
        {
            var asCollection = new PageDataCollection(pages);
            var sortFilter = new FilterSort(FilterSortOrder.PublishedDescending);
            sortFilter.Sort(asCollection);
            return asCollection;
        }
    }
}
