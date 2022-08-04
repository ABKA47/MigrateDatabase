using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Concrete.NewDb
{
    public class BireyselMembersDal : IBireyselMembersDal
    {
        public void Add(BireyselMember bireyselMember)
        {
            using (var context = new SqlDbContext())
            {
                context.BireyselMembers.Add(bireyselMember);
                context.SaveChanges();
            }
            
        }
    }
}

