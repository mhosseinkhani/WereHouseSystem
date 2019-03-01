 

using System.Collections.Generic;
using System.Linq;
using DataWere.Models;

namespace itka.Services
{
    public class EventServices
    {
        private readonly ApplicationDbContext _db;
 
        public EventServices()
        {
            _db = new ApplicationDbContext();
        }
        public List<ApplicationUser> GetAllUsers()
        {
            return _db.Users.ToList();
        }
        public int DeleteUser(string id)
        {
            var usr = _db.Users.FirstOrDefault(x => x.Id == id);
//            usr.status = 0;
            _db.SaveChanges();
            return 1;
        }
    }
}