using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Concrete.NewDb
{
    public class KurumsalMembersDal : IKurumsalMembersDal
    {
        public void Add(KurumsalMember kurumsalMember)
        {
            using (var context = new SqlDbContext())
            {
                context.KurumsalMembers.Add(kurumsalMember);
                context.SaveChanges();
            }
        }
    }
}

