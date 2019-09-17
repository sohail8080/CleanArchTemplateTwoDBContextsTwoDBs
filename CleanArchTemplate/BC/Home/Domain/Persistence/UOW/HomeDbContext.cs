using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CleanArchTemplate.BC.AccessControl.Account.Domain.Models;
using CleanArchTemplate.BC.Home.Domain.Models;
//using CleanArchTemplate.BC.AccessControl.Manage.Domain.Models;

namespace CleanArchTemplate.BC.Home.Domain.Persistence.UOW
{
    // This DBContext will add 5 Tables to the CleanArchTemplateTwoDBContextsOneDB
    // As there is one DB, Migratins sould be stored in One Folder.
    // This Class will extend form DBContext only
    public class HomeDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        public HomeDbContext()
            : base("HomeDB")
        {
        }

        public static HomeDbContext Create()
        {
            return new HomeDbContext();
        }
    }
}