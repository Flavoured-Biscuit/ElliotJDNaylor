using ElliotJDNaylor.Services.Interfaces;
using ElliotJDNaylor.ViewModels;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace ElliotJDNaylor.Controllers
{
    public class ContactController : Controller
    {
        private string RecapthaSiteKey = ConfigurationManager.AppSettings["RecapthaSiteKey"].ToString();
        private string ContactForm_EmailSubject = ConfigurationManager.AppSettings["ContactForm_EmailSubject"].ToString();

        private IEmailService _emailService;

        public ContactController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public ActionResult Index()
        {
            return View(new ContactViewModel
            {
                RecapthaSiteKey = RecapthaSiteKey
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContactViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _emailService.SendEmail(ContactForm_EmailSubject, model.EmailContent, false);

            return RedirectToAction("Confirmation");
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}