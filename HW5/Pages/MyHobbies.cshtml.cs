using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HW5.Model;
using System;

namespace HW5.Pages
{
    public class MyHobbiesModel : PageModel
    {
        [BindProperty]
        public List<Hobby> MyHobbies { get; set; }
        List<Hobby> hobbies;
        public MyHobbiesModel()
        {
            hobbies = new List<Hobby>()
            {
                new Hobby{ HobbyName="Gym", HobbyDescription="Going to the gym."},
                new Hobby {HobbyName = "Hookah", HobbyDescription="Smoking hookah on Fridays."},
                new Hobby {HobbyName="Guitar", HobbyDescription="Playing guitar twice a week."},
                new Hobby{HobbyName="Reading", HobbyDescription="Reading scientific literature."}
            };
        }

        public void OnGet()
        {
            MyHobbies = hobbies;
        }
      
    }
}
