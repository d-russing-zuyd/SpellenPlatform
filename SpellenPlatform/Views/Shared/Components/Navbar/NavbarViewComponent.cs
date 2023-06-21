using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpellenPlatform.Data;
using Microsoft.AspNetCore.Hosting;

namespace SpellenPlatform.Views.Shared.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly SpellenPlatformDbContext _context;

        public NavbarViewComponent(SpellenPlatformDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.Categories.Where(n => n.ShowInNav == true).ToList();

            return View(categories);
        }
    }
}
