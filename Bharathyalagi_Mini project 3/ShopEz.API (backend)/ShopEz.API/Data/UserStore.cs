using ShopEz.API.Models;
using System.Collections.Generic;

namespace ShopEZ.API.Data
{
    public static class UserStore
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "Bharath", Password = "Bharath@7", Role = "Admin" }
        };
    }
}