using CleanArchTemplate.BC.AccessControl.Account.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;

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