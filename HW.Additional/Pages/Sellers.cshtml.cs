using HW.Additional.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HW.Additional.Pages
{
    public class SellersModel : PageModel
    {
        private readonly MyAppContext myAppContext;

        public SellersModel(MyAppContext myAppContext)
        {
            this.myAppContext = myAppContext;
        }
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public List<Owner> Owners { get; set; } = new List<Owner>();
        public async Task OnGetAsync()
        {
            Sellers = await myAppContext.Sellers.ToListAsync();
            Owners = await myAppContext.Owners.ToListAsync();
        }
    }
}
