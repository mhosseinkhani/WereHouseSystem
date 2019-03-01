using itka.Data;
using System;
using System.Linq;
using System.Linq.Dynamic;

namespace itka.Services
{

    public class DeleteServices
    {
        private readonly DbContext _db;
        public DeleteServices() : this(new DbContext()) { }

        public DeleteServices(DbContext agendaContext)
        {
            _db = agendaContext;
        }
        public bool DeleteProduct(int id)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var usr = _db.Products.Where(x => x.id == id).First();
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
                    var usr = _db.Clients.Where(x => x.id == id).First();
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
                    var usr = _db.Suppliers.Where(x => x.id == id).First();
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
                    var usr = _db.Warehouses.Where(x => x.id == id).First();
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
                    var usr = _db.Exits.Where(x => x.id == id).First();
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