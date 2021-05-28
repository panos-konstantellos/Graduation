using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Graduation.Core;
using Graduation.Web.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Graduation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostalCodeProviderService _postalCodeProviderService;
        private readonly EducationContext _educationContext;

        public HomeController(IPostalCodeProviderService postalCodeProviderService, EducationContext educationContext)
        {
            this._postalCodeProviderService = postalCodeProviderService;
            this._educationContext = educationContext;
        }
        
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var departments = await this._educationContext.Departments
                .Include(x => x.DepartmentLocalizations.Where(l => l.LanguageId == 1))
                .ToListAsync(cancellationToken);
            
            return this.View(new FormStepOneModel
            {
                PostalCodes = await this._postalCodeProviderService.GetPostalCodesAsync(cancellationToken) ?? new List<PostalCode>(),
                Departments = departments
                    .Where(x => x.DepartmentLocalizations.Any())
                    .Select(x => new DepartmentModel
                    {
                        Name = x.DepartmentLocalizations.FirstOrDefault()?.Name ?? string.Empty
                    })
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