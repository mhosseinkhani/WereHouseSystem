using itka.Data;
using itka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace itka.Services
{
    public class MainServices
    {
        private readonly DbContext _db;

        public CustomUser GetUser(string email)
        {
            var user = _db.Users.Where(x => x.UserName == email && x.status == 1);
            if (user != null)
            {
                return user.First();
            }
            else
            {
                return null;
            }
        }
    }
}