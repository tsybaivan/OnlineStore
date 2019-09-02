using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Application.Products;
using Store.Database;

namespace OnlineStore.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }
        
        public void OnGet()
        {
            Products = new GetProducts(_ctx).Do();
        }

    }
}
