 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataWere.Models;

namespace itka.Services
{
    public class MainServices
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUser GetUser(string email)
        {
            var user = _db.Users.Where(x => x.UserName == email );
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