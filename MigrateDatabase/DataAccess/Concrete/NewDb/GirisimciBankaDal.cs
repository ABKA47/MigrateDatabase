using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Concrete.NewDb
{
    public class GirisimciBankaDal : IGirisimciBankaDal
    {
        public void Add(GirisimciBanka girisimciBanka)
        {
            using (var context = new SqlDbContext())
            {
                context.GirisimBanka.Add(girisimciBanka);
                context.SaveChanges();
            }
        }
    }
}

