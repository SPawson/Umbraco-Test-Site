using PlainSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace PlainSite.controller
{
    public class ArticlesMainController : RenderMvcController
    {
        // GET: ArticleMain
        public ActionResult Index(IPublishedContent model)
        {
            var articles = new ArticleMainViewModel(model)
            {
                Articles = GetArticleItems(model)
            };

            return base.Index(articles);
        }

        public List<ArticlesItem> GetArticleItems(IPublishedContent model)
        {
            var articles = model.Children.OfType<ArticlesItem>().OrderByDescending(x => x.CreateDate).ToList();
            return articles;
        }
    }
}