using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DillonWallsC2Episerver.Models.Blocks;
using DillonWallsC2Episerver.Models.Pages;
using DillonWallsC2Episerver.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace DillonWallsC2Episerver.Controllers
{
    public class GeneralPageController : PageController<GeneralPage>
    {
        private readonly IContentLoader _contentLoader;
        private readonly IPermanentLinkMapper _permanentLinkMapper;

        //public GeneralPageController(IContentLoader contentLoader, IPermanentLinkMapper permanentLinkMapper)
        //{
        //    _contentLoader = contentLoader;
        //    _permanentLinkMapper = permanentLinkMapper;
        //}

        //public ActionResult Index(GeneralPage currentPage)
        //{  
        //    /* Implementation of action. You can create your own view model class that you pass to the view or
        //     * you can pass the page type for simpler templates */

        //    HeaderBlock headerBlock = null;
        //    if (!ContentReference.IsNullOrEmpty(currentPage.Header))
        //    {
        //        headerBlock = _contentLoader.Get<HeaderBlock>(currentPage.Header);
        //    }

        //    var model = new GeneralPageModel
        //    {
        //        Header = headerBlock,
        //        BannerImage = currentPage.BannerImage,
        //        Title = currentPage.Title,
        //        SubTitle = currentPage.SubTitle,
        //        MainBody = currentPage.MainBody
        //    };

        //    //As we're using a separate view model with different property names than the content object
        //    //we connect the view models properties with the content objects so that they can be edited.
        //    ViewData.GetEditHints<GeneralPageModel, GeneralPage>()
        //        .AddConnection(x => x.Title, x => x.Title)
        //        .AddConnection(x => x.SubTitle, x => x.SubTitle)
        //        .AddConnection(x => x.MainBody, x => x.MainBody)
        //        .AddConnection(x => x.BannerImage, x => x.BannerImage)
        //        .AddConnection(x => (object)x.Header, x => (object)x.Header);


        //    return PartialView(model);
        //}

        public ActionResult Index(GeneralPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            return View(currentPage);
        }
    }
}