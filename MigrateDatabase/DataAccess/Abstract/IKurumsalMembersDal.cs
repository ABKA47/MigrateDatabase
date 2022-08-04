using System;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IKurumsalMembersDal
    {
        void Add(KurumsalMember kurumsalMember);
    }
}

