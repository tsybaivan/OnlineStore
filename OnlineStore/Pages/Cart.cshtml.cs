using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Store.Application.Cart;
using Store.Database;

namespace OnlineStore.Pages
{
    public class CartModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IEnumerable<GetCart.Response> Cart { get; set; }

        public CartModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult OnGet()
        {
            Cart = new GetCart(HttpContext.Session, _ctx).Do();
            return Page();
        }
    }
}