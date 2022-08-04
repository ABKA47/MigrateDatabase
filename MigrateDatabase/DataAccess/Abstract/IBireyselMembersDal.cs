using System;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IBireyselMembersDal
    {
        void Add(BireyselMember bireyselMember);
    }
}

