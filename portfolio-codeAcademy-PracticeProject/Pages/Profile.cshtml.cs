using Microsoft.AspNetCore.Mvc.RazorPages;

namespace portfolio_codeAcademy_PracticeProject.Pages
{
    public class Profile : PageModel
    {
        public string Greeting(string firstName) => "Dear," + firstName;
       

        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string greetingMessage { get; set; }

        public void OnGet()
        {
            FirstName = "Edine";
            Age = 19;
            Gender = "female";
            City = "Kigali";
            greetingMessage = Greeting(FirstName);
        }
    }
}
