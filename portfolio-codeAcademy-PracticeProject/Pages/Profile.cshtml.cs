using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace portfolio_codeAcademy_PracticeProject.Pages
{
    public class Profile : PageModel
    {
        public string Greeting(string firstName) => "Dear, " + firstName;

        [BindProperty]
        public string FirstName { get; set; }

        [BindProperty]
        public string City { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public string greetingMessage { get; set; }
        public string testingRedirecting { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            await Task.CompletedTask;
            
            // testingRedirecting = "brabrabra";
            if (string.IsNullOrEmpty(testingRedirecting)) 
            {
                return NotFound();
            }

            ViewData["FirstName"] = "Edine";
            ViewData["Age"] = 20;
            ViewData["Gender"] = "Female";
            City = "Kigali";
            greetingMessage = Greeting("Edine");

            return Page();
        }

        public async Task OnPostAsync()
        {
            await Task.CompletedTask;

            ViewData["FirstName"] = FirstName;
            ViewData["Age"] = 20;
            ViewData["Gender"] = "Female";
            greetingMessage = Greeting(FirstName);
        }
    }
}