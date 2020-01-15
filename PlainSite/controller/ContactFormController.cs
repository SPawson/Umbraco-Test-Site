using PlainSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace PlainSite.controller
{
    public class ContactFormController : SurfaceController
    {
        [HttpPost]
        public ActionResult Submit(ContactFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            var response = new ContactFormViewModel()
            {
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Email = model.Email,
                Message = model.Message
            };

            TempData["Firstname"] = response.Firstname;
            TempData["Lastname"] = response.Lastname;

            //return PartialView("/Views/Partials/ContactForm.cshtml", response);
            return RedirectToCurrentUmbracoPage();
        }
    }
}
