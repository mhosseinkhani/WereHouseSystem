using System.Data.Entity.Migrations;
using DataWere.Models;

namespace DataWere.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            
        }

        protected override async void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
//            var passwordHash = new PasswordHasher();
//            string password = passwordHash.HashPassword("1234567");
//
//            var roles = ApplicationRoleManager.Create(HttpContext.Current.GetOwinContext());
//
//            if (!context.Roles.Any())
//            {
//                 roles.Create(new IdentityRole { Name = SecurityRoles.Admin });
//            }
//            if(!context.Users.Any()) {
//                CustomUser cu = new CustomUser()
//                {
//                    UserName = "admin",
//                    UserFirstName = "Admin",
//                    UserLastName = "Admin",
//                    Email = "admin@admin.com",
//                    Id = Guid.NewGuid().ToString(),
//                    PasswordHash = password,
//                    SecurityStamp = Guid.NewGuid().ToString(),
//                    PhoneNumber = "0",
//                    EmailConfirmed = false,
//                    PhoneNumberConfirmed = false,
//                    TwoFactorEnabled = false,
//                    LockoutEnabled = false,
//                    AccessFailedCount = 0
//                };
//                context.Users.AddOrUpdate(c => c.Email, cu);
//                context.SaveChanges();
//                string role = context.Roles.First(x => x.Name == "admin").Id;
//                context.Database.ExecuteSqlCommand("INSERT INTO \"AspNetUserRoles\" VALUES('" + cu.Id + "','" + role + "')");
//            }
        }        
    }
}
