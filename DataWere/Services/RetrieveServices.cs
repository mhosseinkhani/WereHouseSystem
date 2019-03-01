using System;
using System.Collections.Generic;
using System.Linq;
using DataWere.Models;
using DataWere.ViewModels;

namespace itka.Services
{
    public class RetrieveServices
    {
        private readonly ApplicationDbContext _db;
 
        public RetrieveServices( )
        {
            _db = new ApplicationDbContext();
        }
        public IEnumerable<tblProduct> GetProducts()
        {
            return _db.Products.Where(x => x.status == true).ToList();
        }
        public IEnumerable<tblClient> GetClients()
        {
            return _db.Clients.Where(x => x.status == true).ToList();
        }
        public IEnumerable<tblUnit> GetUnits()
        {
            return _db.Units.Where(x => x.status == true).ToList();
        }
        public IEnumerable<tblSupplier> GetSuppliers()
        {
            return _db.Suppliers.Where(x => x.status == true).ToList();
        }
        public IEnumerable<tblWarehouse> GetWarehouses()
        {
            return _db.Warehouses.Where(x => x.status == true).ToList();
        }
        public IEnumerable<tblUnit> GetUnitsDatatable(string st, string ln, string search)
        {
            int _skip = Int32.Parse(st);
            int _take = Int32.Parse(ln);
            IEnumerable<tblUnit> items = (from item in _db.Units
                                          where item.status == true && (item.name.ToLower().Contains(search.ToLower()) || item.description.ToLower().Contains(search.ToLower()) || search == "")
                                          select item).OrderBy(x => x.name).Skip(_skip).Take(_take).ToList();
            return items;
        }
        public IEnumerable<tblSupplier> GetSuppliersDatatable(string st, string ln, string search)
        {
            int _skip = Int32.Parse(st);
            int _take = Int32.Parse(ln);
            IEnumerable<tblSupplier> items = (from item in _db.Suppliers
                                          where item.status == true && (item.name.ToLower().Contains(search.ToLower()) || item.surname.ToLower().Contains(search.ToLower()) || search == "")
                                          select item).OrderBy(x => x.name).Skip(_skip).Take(_take).ToList();
            return items;
        }
        public IEnumerable<tblClient> GetClientsDatatable(string st, string ln, string search)
        {
            int _skip = Int32.Parse(st);
            int _take = Int32.Parse(ln);
            IEnumerable<tblClient> items = (from item in _db.Clients
                                              where item.status == true && (item.name.ToLower().Contains(search.ToLower()) || item.surname.ToLower().Contains(search.ToLower()) || search == "")
                                              select item).OrderBy(x => x.name).Skip(_skip).Take(_take).ToList();
            return items;
        }
        public IEnumerable<tblWarehouse> GetWarehousesDatatable(string st, string ln, string search)
        {
            int _skip = Int32.Parse(st);
            int _take = Int32.Parse(ln);
            IEnumerable<tblWarehouse> items = (from item in _db.Warehouses
                                            where item.status == true && (item.name.ToLower().Contains(search.ToLower()) || search == "")
                                            select item).OrderBy(x => x.name).Skip(_skip).Take(_take).ToList();
            return items;
        }
        public IEnumerable<ProductViewModel> GetProductsDatatable(string st, string ln, string search)
        {
            int _skip = Int32.Parse(st);
            int _take = Int32.Parse(ln);
            IEnumerable<tblProduct> items = (from item in _db.Products
                                               where item.status == true && (item.name.ToLower().Contains(search.ToLower()) || search == "")
                                               select item).OrderBy(x => x.name).Skip(_skip).Take(_take).ToList();
            List<ProductViewModel> final = new List<ProductViewModel>();
            foreach(var i in items)
            {
                ProductViewModel product = new ProductViewModel() {
                    unit = _db.Units.Where(x=> x.id == i.idunit).First().name,
                    Product = i
                };
                final.Add(product);
            }
            return final;
        }        
    }
}