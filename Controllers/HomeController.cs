using ElliotJDNaylor.Models;
using ElliotJDNaylor.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ElliotJDNaylor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeViewModel 
            {
                Links = new List<Link>
                {
                    new Link { ButtonText = "CV", ButtonUrl = Url.Action("Index", "CV"), ButtonColour = "orange" },
                    new Link { ButtonText = "Projects", ButtonUrl = Url.Action("Index", "Projects"), ButtonColour = "blue" },
                    new Link { ButtonText = "Contact", ButtonUrl = Url.Action("Index", "Contact"), ButtonColour = "brown" },
                }
            });
        }
    }
}