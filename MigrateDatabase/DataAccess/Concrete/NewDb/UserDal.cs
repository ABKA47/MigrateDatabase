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
    public class UserDal : IUserDal
    {
        public void Add(Users user)
        {
            using (var context = new SqlDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
