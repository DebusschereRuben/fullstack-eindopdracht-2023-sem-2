using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;

using TreinTickets.Models.Data;
using TreinTickets.Models.Entities;

namespace TreinTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly TreinTicketsDbContext _context;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer, TreinTicketsDbContext context)
        {
            _logger = logger;
            _localizer = localizer;
            _context = context; 
        }

        public IActionResult Index()//home pagina
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetAppLanguage(string lang, string returnUrl)
        {
            // er wordt een cookie aangemaakt met de naam .AspNetCore.Culture (zie browser cookie)
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(lang)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }
    }
}