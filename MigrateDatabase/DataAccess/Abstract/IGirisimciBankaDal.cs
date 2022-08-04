using System;
using MigrateDatabase.DataAccess.Concrete.NewDb;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IGirisimciBankaDal
    {
        void Add(GirisimciBanka girisimciBanka);
    }
}

