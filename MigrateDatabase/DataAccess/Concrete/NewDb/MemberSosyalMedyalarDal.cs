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
    public class MemberSosyalMedyalarDal : IMemberSosyalMedyalarDal
    {
        public void Add(MemberSosyalMedyalar memberSosyalMedyalar)
        {
           using(var context = new SqlDbContext())
            {
                context.MemberSosyalMedyalar.Add(memberSosyalMedyalar);
                context.SaveChanges();
            }
        }
    }
}
