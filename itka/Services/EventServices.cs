using itka.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using itka.Models;

namespace itka.Services
{
    public class EventServices
    {
        private readonly DbContext _db;
        public EventServices() : this(new DbContext()) { }

        public EventServices(DbContext agendaContext)
        {
            _db = agendaContext;
        }
        public List<CustomUser> GetAllUsers()
        {
            return _db.Users.ToList();
        }
        public int DeleteUser(string id)
        {
            CustomUser usr = _db.Users.Where(x => x.Id == id).FirstOrDefault();
            usr.status = 0;
            _db.SaveChanges();
            return 1;
        }
    }
}