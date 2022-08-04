using System;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IMemberBanksDal
    {
        List<MemberBanks> GetMemberBanks();
    }
}

