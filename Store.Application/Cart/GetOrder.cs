﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Store.Database;
using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Application.Cart
{
    public class GetOrder
    {
        private ISession _session;

        private ApplicationDbContext _ctx;

        public GetOrder(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {
            public IEnumerable<Product> Products { get; set; }

            public CustomerInformation CustomerInformation { get; set; }

            public int GetTotalCharge() => Products.Sum(x => (int)x.Value * x.Qty); 
        }

        public class Product
        {
            public int ProductId { get; set; }

            public int StockId { get; set; }

            public int Qty { get; set; }

            public decimal Value { get; set; }
        }

        public class CustomerInformation
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public string PostCode { get; set; }
        }

        public Response Do()
        {
            var cart = _session.GetString("cart");

            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(cart);

            var listOfProduct = _ctx.Stock
                .Include(x => x.Product)
                .Where(x => cartList.Any(y => y.StockId == x.Id))
                .Select(x => new Product
                {
                    ProductId = x.ProductId,
                    StockId = x.Id,
                    Value = x.Product.Value * 100,
                    Qty = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
                }).ToList();

            var customerInfoString = _session.GetString("customer-info");

            var customerInformation = JsonConvert.DeserializeObject<Store.Domain.Models.CustomerInformation>(customerInfoString);

            return new Response
            {
                Products = listOfProduct,
                CustomerInformation = new CustomerInformation
                {
                    FirstName = customerInformation.FirstName,
                    LastName = customerInformation.LastName,
                    Email = customerInformation.Email,
                    PhoneNumber = customerInformation.PhoneNumber,
                    Address1 = customerInformation.Address1,
                    Address2 = customerInformation.Address2,
                    City = customerInformation.City,
                    PostCode = customerInformation.PostCode
                }
            };
        }
    }
}
