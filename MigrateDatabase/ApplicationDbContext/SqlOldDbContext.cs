using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MigrateDatabase.Entities;
using MigrateDatabase.Entities.Abstract;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.ApplicationDbContext
{
    public class SqlOldDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=fonangelsdb;");
        }

       //public DbSet<T> Tables { get; set; }
       public DbSet<tblBanks> tblBanks { get; set; }
       public DbSet<tblEntMainCategory> tblEntMainCategories { get; set; }
       public DbSet<tblPaymentTypes> tblPaymentTypes { get; set; }
       public DbSet<TblMember> tblMember { get; set; }
       public DbSet<tblEduTitles> tblEduTitles { get; set; }
       public DbSet<tblOccupations> tblOccupations { get; set; }
       public DbSet<tblAcademicTitles> tblAcademicTitles { get; set; }
    }
}

