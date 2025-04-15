// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace portfolio_codeAcademy_PracticeProject.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName {get; set;}
        public string LinkedInUsername {get; set;}
        public int YearsOfExperience {get; set;}
        public List<string> Languages {get; set;}
		
        public void OnGet(){
            Languages = new List<string>{
                "English",
                "French",
                "Japanese"
            };
    
        }

  
    }
}