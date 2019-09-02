using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store.Application.ProductsAdmin;
using Store.Application.StockAdmin;
using Store.Application.UsersAdmin;
using Store.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{ 
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]    
    public class UsersController : Controller
    {
        private CreateUser _createUser;

        public UsersController(CreateUser createUser)
        {
            _createUser = createUser;
        }
        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request)
        {
            await _createUser.Do(request);
            return Ok();
        }

    }
}
