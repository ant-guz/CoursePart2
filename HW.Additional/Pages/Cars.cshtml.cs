using HW.Additional.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW.Additional.Pages
{
    public class CarsModel : PageModel
    {
        private readonly MyAppContext myAppContext;

        public CarsModel(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
        }
        public List<Car> Cars { get; set; } = new List<Car>();
       
        public async Task OnGetAsync()
        {
            Cars = await myAppContext.Cars.ToListAsync();
           
        }
    }
}
