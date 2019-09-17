using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CleanArchTemplate.BC.AccessControl.Account.Domain.Models;

namespace CleanArchTemplate.BC.AccessControl.UOW
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // This DBContext will add 5 Tables to the CleanArchTemplateTwoDBContextsOneDB
        // As there is one DB, Migratins sould be stored in One Folder.
        public ApplicationDbContext()
            : base("AccountDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}