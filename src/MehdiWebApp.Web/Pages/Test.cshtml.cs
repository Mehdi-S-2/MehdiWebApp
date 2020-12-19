using MehdiWebApp.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace MehdiWebApp.Web.Pages
{
    public class TestModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public TestModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            ViewData["phone"] = await _userManager.GetPhoneNumberAsync(user);
            //_userManager.SetLockoutEndDateAsync(user, )
        }
    }
}