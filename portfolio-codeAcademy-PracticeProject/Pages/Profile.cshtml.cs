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

        public async Task OnGetAsync()
        {
            await Task.CompletedTask;

            ViewData["FirstName"] = "Edine";
            ViewData["Age"] = 20;
            ViewData["Gender"] = "Female";
            City = "Kigali";
            greetingMessage = Greeting("Edine");
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