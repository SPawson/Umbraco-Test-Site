using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.ModelsBuilder;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedModels;

namespace PlainSite.ViewModels
{
    public class BlogContainerViewModel : ContentModel
    {
        //constructor uses IPublished content in order to pass this into the view through the viewmodel
        public BlogContainerViewModel(IPublishedContent content)
            : base(content)
        {

        }

        public List<BlogItem> BlogPosts { get; set;} 


    }
}