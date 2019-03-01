using System.Data.Entity;
using itka.Models;
using itka.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;

namespace itka.Data
{
    public class DbContext: IdentityDbContext<CustomUser>
    {
        public DbContext() : base("DefaultConnection") {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Configuration>());

        }
        public static DbContext Create()
        {            
            return new DbContext();
        }     
        public DbSet<tblEvent> Events { get; set; }
        public DbSet<tblClient> Clients { get; set; }
        public DbSet<tblUnit> Units { get; set; }
        public DbSet<tblSupplier> Suppliers { get; set; }
        public DbSet<tblProduct> Products { get; set; }
        public DbSet<tblEntry> Entries { get; set; }
        public DbSet<tblExit> Exits { get; set; }
        public DbSet<tblWarehouse> Warehouses { get; set; }
        public DbSet SetTbl(string name)
        {
            // you may need to fill in the namespace of your context
            return base.Set(Type.GetType(name));
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder
            //  .Properties()
            //  .Where(p => p.PropertyType == typeof(string) &&
            //              !p.Name.Contains("Id") &&
            //              !p.Name.Contains("Provider"))
            //  .Configure(p => p.HasMaxLength(2000));
        }

        internal IQueryable SetTbl(Type tType)
        {
            return base.Set(tType);
        }
    }
}