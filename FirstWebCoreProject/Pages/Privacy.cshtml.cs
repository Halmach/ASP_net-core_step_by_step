using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebCoreProject.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly LinkGenerator _link;

        public PrivacyModel(ILogger<PrivacyModel> logger, LinkGenerator linkGenerator)
        {
            _logger = logger;
            _link = linkGenerator;
        }

        public IActionResult OnGet()
        {
            var url1 = Url.Page("/Error");
            return RedirectToPage(url1);
        }
    }
}
