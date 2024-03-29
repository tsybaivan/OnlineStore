﻿using Microsoft.EntityFrameworkCore;
using Store.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Application.OrdersAdmin
{
    public class GetOrder
    {
        private ApplicationDbContext _ctx;

        public GetOrder(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public class Response
        {
            public int Id { get; set; }

            public string StripeReference { get; set; }

            public string OrderRef { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public string PostCode { get; set; }

            public IEnumerable<Product> Products { get; set; }
        }

        public class Product
        {
            public string Name { get; set; }

            public string Description { get; set; }

            public int Qty { get; set; }

            public string StockDescription { get; set; }
        }

        public Response Do(int id) =>
            _ctx.Orders
            .Where(x => x.Id == id)
            .Include(x => x.OrderStocks)
            .ThenInclude(x => x.Stock)
            .ThenInclude(x => x.Product)
            .Select(x => new Response
            {
                Id = x.Id,
                OrderRef = x.OrderRef,
                StripeReference = x.StripeReference,

                FirstName = x.StripeReference,
                LastName = x.StripeReference,
                Email = x.StripeReference,
                PhoneNumber = x.StripeReference,
                Address1 = x.StripeReference,
                Address2 = x.StripeReference,
                City = x.StripeReference,
                PostCode = x.StripeReference,

                Products = x.OrderStocks.Select(y => new Product
                {
                    Name = y.Stock.Product.Name,
                    Description = y.Stock.Description,
                    Qty = y.Qty,
                    StockDescription = y.Stock.Description,
                }),

            }).FirstOrDefault();
    }
}
