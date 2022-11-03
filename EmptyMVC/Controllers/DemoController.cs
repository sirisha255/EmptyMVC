using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace EmptyMVC.Controllers
{
    public class DemoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PreferdLanguageCookie()
        {
            String? lang = Request.Cookies["PrefLang"];
            if (!string.IsNullOrEmpty(lang))
            {
                ViewBag.Lang = lang;
            }

            return View();
        }
        public IActionResult SetLanguageCookie(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Append("PrefLang", lang, option);

            }
            return RedirectToAction(nameof(PreferdLanguageCookie));
        }

    }
}
