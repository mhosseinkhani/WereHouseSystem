using itka.Data;
using itka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace itka.Services
{
    public class UpdateServices
    {
        private readonly DbContext _db;
        public UpdateServices() : this(new DbContext()) { }

        public UpdateServices(DbContext agendaContext)
        {
            _db = agendaContext;
        }
        public bool SaveChangesProduct(tblProduct model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    tblProduct item = _db.Products.Where(x => x.id == model.id).FirstOrDefault();
                    item.name = model.name;
                    item.number = model.number;
                    item.idunit = model.idunit;
                    item.description = model.description;
                    item.status = model.status;
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
        public bool SaveChangesUnit(tblUnit model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    tblUnit item = _db.Units.Where(x => x.id == model.id).FirstOrDefault();
                    item.name = model.name;
                    item.description = model.description;
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
        public bool SaveChangesClient(tblClient model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    tblClient item = _db.Clients.Where(x => x.id == model.id).FirstOrDefault();
                    item.name = model.name;
                    item.surname = model.surname;
                    item.email = model.email;
                    item.description = model.description;
                    item.company = model.company;
                    item.nipt = model.nipt;
                    item.phone1 = model.phone1;
                    item.phone2 = model.phone2;
                    item.address = model.address;
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
        public bool SaveChangesSupplier(tblSupplier model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    tblSupplier item = _db.Suppliers.Where(x => x.id == model.id).FirstOrDefault();
                    item.name = model.name;
                    item.surname = model.surname;
                    item.email = model.email;
                    item.description = model.description;
                    item.company = model.company;
                    item.nipt = model.nipt;
                    item.phone1 = model.phone1;
                    item.phone2 = model.phone2;
                    item.address = model.address;
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
        public bool SaveChangesWarehouse(tblWarehouse model)
        {
            using (var dbContextTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                    tblWarehouse item = _db.Warehouses.Where(x => x.id == model.id).FirstOrDefault();
                    item.name = model.name;                   
                    item.address = model.address;
                    item.description = model.description;
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