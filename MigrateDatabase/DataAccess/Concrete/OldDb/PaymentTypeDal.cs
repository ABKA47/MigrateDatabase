using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess
{
    public class PaymentTypeDal:IPaymentTypeDal
    {
        public List<tblPaymentTypes> getPayments()
        {
            using (var context = new SqlOldDbContext())
            {
                var result = context.tblPaymentTypes;

                return result.ToList();
            }
        }
    }
}

