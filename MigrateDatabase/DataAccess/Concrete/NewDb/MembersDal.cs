using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.Concrete.NewDb
{
    public class MembersDal : IMembersDal
    {
        public void Add(Member member)
        {
            using (var context = new SqlDbContext())
            {
                context.Members.Add(member);
                context.SaveChanges();
            }
        }
    }
}

