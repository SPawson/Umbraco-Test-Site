using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using PlainSite.ViewModels;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace PlainSite.controller
{
    public class BlogContainerController : RenderMvcController
    {
        // GET: blogContainer
        public ActionResult Index(IPublishedContent model)
        {
            var blogs = new BlogContainerViewModel(model)
            {
                BlogPosts = GetBlogItems(model)
            };

            return base.Index(blogs);
        }

        public List<BlogItem> GetBlogItems(IPublishedContent model)
        {
            var blogposts = model.Children<BlogItem>().Where(x => x.IsVisible()).OrderByDescending(x => x.PublishedDate).ToList();
            return blogposts;
        }
    }
}