using HW.Additional.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW.Additional.Pages
{
    public class OwnersModel : PageModel
    {
        private readonly MyAppContext myAppContext;

        public OwnersModel(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
        }
        public List<Owner> Owners { get; set; } = new List<Owner>();
        public List<Car> Cars { get; set; } = new List<Car>();
        public async Task OnGetAsync()
        {
            Owners = await myAppContext.Owners.ToListAsync();
            Cars = await myAppContext.Cars.ToListAsync();
        }
    }
}
