﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Application.OrdersAdmin;
using Store.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class OrdersController : Controller
    {
        private ApplicationDbContext _ctx;

        public OrdersController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("")]
        public IActionResult GetOrders(int status) => Ok(new GetOrders(_ctx).Do(status));

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id) => Ok(new GetOrder(_ctx).Do(id));

        [HttpGet("{id}")]
        public async Task<IActionResult> UpdateOrder(int id) => Ok((await new UpdateOrder(_ctx).Do(id)));
    }
}
