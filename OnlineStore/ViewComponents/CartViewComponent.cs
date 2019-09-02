using Microsoft.AspNetCore.Mvc;
using Store.Application.Cart;
using Store.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private ApplicationDbContext _ctx;

        public CartViewComponent(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            if(view == "small")
            {
                var totalValue = new GetCart(HttpContext.Session, _ctx).Do().Sum(x => x.RealValue * x.Qty);

                return View(view, $"$ {totalValue}");
            }

            return View(view, new GetCart(HttpContext.Session, _ctx).Do());
        }
    }
}
