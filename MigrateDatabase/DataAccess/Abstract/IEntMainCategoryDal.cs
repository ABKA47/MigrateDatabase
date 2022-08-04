using System;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IEntMainCategoryDal
    {
        List<tblEntMainCategory> GetEntMainCategories();
    }
}

