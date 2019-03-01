using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace itka.Models
{
    public class CustomUser : IdentityUser
    {
      
        [Display(Name = "First Name")]
        public string UserFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string UserLastName { get; set; }
        [Display(Name = "Address")]
        public string UserAddress { get; set; }
      
        [Display(Name = "Phone Number")]
        public string UserPhoneNumber { get; set; }
        public string ImgURL { get; set; }   
        public int status { get; set; } //1-active // 0 -deleted
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync
            (UserManager<CustomUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this,
                DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public static class SecurityRoles
    {
        public const string Admin = "admin";
        public const string User = "user";
    }
}
