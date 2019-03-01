using itka.Data;
using itka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace itka.Services
{
    public class DetailsServices
    {
        private readonly DbContext _db;
        public DetailsServices() : this(new DbContext()) { }

        public DetailsServices(DbContext agendaContext)
        {
            _db = agendaContext;
        }
        public tblUnit UnitDetails(int id)
        {
            return _db.Units.Where(x => x.id == id).FirstOrDefault();
        }
        public tblClient ClientDetails(int id)
        {
            return _db.Clients.Where(x => x.id == id).FirstOrDefault();
        }
        public tblProduct ProductDetails(int id)
        {

            return _db.Products.Where(x => x.id == id).FirstOrDefault();
        }
        public tblSupplier SupplierDetails(int id)
        {
            return _db.Suppliers.Where(x => x.id == id).FirstOrDefault();
        }         
        public tblWarehouse WarehouseDetails(int id)
        {
            return _db.Warehouses.Where(x => x.id == id).FirstOrDefault();
        }
    }
}