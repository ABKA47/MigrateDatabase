using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.OldDb
{
    public class EntMainCategoryDal:IEntMainCategoryDal
    {
       public List<tblEntMainCategory> GetEntMainCategories()
        {
            using(var context = new SqlOldDbContext())
            {
                var result = context.tblEntMainCategories;

                return result.ToList();
            }
        }
    }
}

