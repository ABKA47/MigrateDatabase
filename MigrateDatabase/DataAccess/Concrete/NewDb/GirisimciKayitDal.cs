using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDatabase.DataAccess.Concrete.NewDb
{
    public class GirisimciKayitDal : IGirisimciKayitDal
    {
        public void Add(GirisimciKayit girisimciKayit)
        {
            using (var context = new SqlDbContext())
            {
                context.GirisimKayit.Add(girisimciKayit);
                context.SaveChanges();
            }
        }
    }
}
