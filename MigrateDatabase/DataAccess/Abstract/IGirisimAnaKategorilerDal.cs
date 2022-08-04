using System;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IGirisimAnaKategorilerDal
    {
        void Add(GirisimAnaKategoriler girisimAnaKategoriler);
    }
}

