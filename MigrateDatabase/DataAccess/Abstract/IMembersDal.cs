using System;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IMembersDal
    {
        void Add(Member member);
    }
}

