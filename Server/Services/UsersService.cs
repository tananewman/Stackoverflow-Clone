using System.Collections.Generic;
using BlazorUiDemo.Shared;
using BlazorUiDemo.Server.Repo;
using System.Linq;

namespace BlazorUiDemo.Server.Services
{
    public class UsersService
    {
        public UserModel GetUserByUserId(string userId)
        {
            return UserData.GetUsers().Single(x => x.Uuid == userId);
        }
    }
}
