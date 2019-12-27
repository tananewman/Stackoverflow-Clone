using BlazorUiDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorUiDemo.Server.Repo;

namespace BlazorUiDemo.Server.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        // Fake test data
        private IList<UserModel> users = UserData.GetUsers();

        [HttpGet]
        [Route("{id}")]
        public UserModel Get(string id)
        {
            return users.Single(x => x.Uuid == id);
        }
    }
}
