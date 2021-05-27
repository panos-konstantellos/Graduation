using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using Graduation.Core;
using Graduation.Web.Models;

using Microsoft.AspNetCore.Mvc;

namespace Graduation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostalCodeProviderService _postalCodeProviderService;

        public HomeController(IPostalCodeProviderService postalCodeProviderService)
        {
            this._postalCodeProviderService = postalCodeProviderService;
        }
        
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            return this.View(new FormStepOne
            {
                PostalCodes = await this._postalCodeProviderService.GetPostalCodesAsync(cancellationToken) ?? new List<PostalCode>()
            });
        }
        
        public IActionResult Privacy()
        {
            return this.View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}