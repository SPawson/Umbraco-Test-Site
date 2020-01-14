using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace PlainSite.ViewModels
{
    public class ArticleMainViewModel : ContentModel
    {
        //constructor uses IPublished content in order to pass this into the view through the viewmodel
        public ArticleMainViewModel(IPublishedContent content)
            : base(content)
        {

        }

        public List<ArticlesItem> Articles { get; set; }


    }
}