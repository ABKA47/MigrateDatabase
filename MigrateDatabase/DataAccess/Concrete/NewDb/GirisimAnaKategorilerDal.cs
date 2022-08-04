using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.NewDb
{
    public class GirisimAnaKategorilerDal:IGirisimAnaKategorilerDal
    {
        public void Add(GirisimAnaKategoriler girisimAnaKategoriler)
        {
            using(var context = new SqlDbContext())
            {
                context.GirisimAnaKategoriler.Add(girisimAnaKategoriler);
                context.SaveChanges();
            }
        }
    }
}

