
using System.Linq;
using DataWere.Models;

namespace itka.Services
{
    public class DetailsServices
    {
        private readonly ApplicationDbContext _db;
        public DetailsServices() { _db = new ApplicationDbContext(); }

        public tblUnit UnitDetails(int id)
        {
            return _db.Units.FirstOrDefault(x => x.id == id);
        }
        public tblClient ClientDetails(int id)
        {
            return _db.Clients.FirstOrDefault(x => x.id == id);
        }
        public tblProduct ProductDetails(int id)
        {

            return _db.Products.FirstOrDefault(x => x.id == id);
        }
        public tblSupplier SupplierDetails(int id)
        {
            return _db.Suppliers.FirstOrDefault(x => x.id == id);
        }
        public tblWarehouse WarehouseDetails(int id)
        {
            return _db.Warehouses.FirstOrDefault(x => x.id == id);
        }
    }
}