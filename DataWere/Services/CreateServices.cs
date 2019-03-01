using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DataWere.Models;
using DataWere.ViewModels;

namespace itka.Services
{
    public class CreateServices
    {
        private readonly ApplicationDbContext _db;

        public CreateServices()
        {
            _db=new ApplicationDbContext();
        }
  
        public bool SaveProduct(ProductViewModel model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Products.Add(model.Product);                   
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveUnit(tblUnit model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Units.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveClient(tblClient model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Clients.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public bool SaveSupplier(tblSupplier model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Suppliers.Add(model);
                    _db.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
        public async Task<bool> SaveWarehouse(tblWarehouse model)
        {
            using (var dbContextTransaction = new ApplicationDbContext())
            {
                try
                {
                    dbContextTransaction.Warehouses.Add(model);
                   await dbContextTransaction.SaveChangesAsync();
//                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
//                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
    }
}