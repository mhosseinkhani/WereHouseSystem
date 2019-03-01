 using System;
using System.Linq;
 using DataWere.Models;

namespace itka.Services
{

    public class DeleteServices
    {
        private readonly ApplicationDbContext _db;

        public DeleteServices()
        {
            _db = new ApplicationDbContext();}

     
        public bool DeleteProduct(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Products.First(x => x.id == id);
                    usr.status = false;
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
        public bool DeleteUnit(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {

                    //var usr = _db.SetTbl(table).AsQueryable().Where("id ==" + id).Select();
                    string strTableName = "tblUnits";
                    _db.Database.ExecuteSqlCommand("UPDATE \""+ strTableName + "\" SET \"status\" = 'false' WHERE id =" + id);
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
        public bool DeleteClient(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Clients.First(x => x.id == id);
                    usr.status = false;
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
        public bool DeleteSupplier(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Suppliers.First(x => x.id == id);
                    usr.status = false;
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
        public bool DeleteWarehouse(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Warehouses.First(x => x.id == id);
                    usr.status = false;
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
        public bool DeleteExit(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Exits.First(x => x.id == id);
                    usr.status = false;
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
        public bool DeleteEntry(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Entries.Where(x => x.id == id).First();
                    usr.status = false;
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
    }
}