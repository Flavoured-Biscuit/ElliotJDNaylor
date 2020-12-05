using ElliotJDNaylor.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElliotJDNaylor.Controllers
{
    public class ErrorController : Controller
    {
        private IEmailService _emailService;

        public ErrorController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public ActionResult Error_404()
        {
            return View();
        }

        public ActionResult Error_500()
        {
            var error = Server.GetLastError();
            Server.ClearError();
            if (error != null)
                _emailService.SendEmail("An unexpected error occurred from elliotnaylor.dev", error.ToString());

            return View();
        }
    }
}