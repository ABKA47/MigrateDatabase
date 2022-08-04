using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MigrateDatabase.Entities.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.ApplicationDbContext
{
    public class SqlDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=Fonangels; User ID= sa;Password=Abka2371..;Persist Security Info=False; TrustServerCertificate=False; MultipleActiveResultSets=true;Connection Timeout=30;");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<GirisimAnaKategoriler> GirisimAnaKategoriler {get;set;}

        public DbSet<GirisimciBanka> GirisimBanka { get; set; }
        public DbSet<GirisimciKayit> GirisimKayit { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<BireyselMember> BireyselMembers { get; set; }
        public DbSet<KurumsalMember> KurumsalMembers { get; set; }
    }
}
