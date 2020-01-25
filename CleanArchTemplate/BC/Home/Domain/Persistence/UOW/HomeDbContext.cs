using CleanArchTemplate.BC.Home.Domain.Models;
using System.Data.Entity;
//using CleanArchTemplate.BC.AccessControl.Manage.Domain.Models;

namespace CleanArchTemplate.BC.Home.Domain.Persistence.UOW
{
    // This DBContext will add 1 Tables to the CleanArchTemplateTwoDBContextsOneDB
    // As there is one DB, Migratins sould be stored in One Folder.
    // This Class will extend form DBContext only
    public class HomeDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        // own connection string
        // two conn string two dbs two migrations folder two domain models
        // two applications under one solution

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