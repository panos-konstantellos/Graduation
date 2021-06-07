using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using Graduation.Web.Models;

using Microsoft.AspNetCore.Mvc;

namespace Graduation.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            return this.View(new HomeViewModel
            {
                GoalTitle = @"Αποστολή της Μονάδας Προσβασιμότητας",
                GoalDescription = @"είναι η επίτευξη στην πράξη της ισότιμης πρόσβασης στις ακαδημαϊκές σπουδές των φοιτητών με διαφορετικές ικανότητες και απαιτήσεις, μέσω της παροχής προσαρμογών στο περιβάλλον, Υποστηρικτικών Τεχνολογιών Πληροφορικής και Υπηρεσιών Πρόσβασης.",
                QuickActionTitle = @"Γρήγορη Πρόσβαση"
            });
        }
        
        public IActionResult Privacy()
        {
            return this.View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}