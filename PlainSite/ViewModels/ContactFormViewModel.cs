using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlainSite.ViewModels
{
    public class ContactFormViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}