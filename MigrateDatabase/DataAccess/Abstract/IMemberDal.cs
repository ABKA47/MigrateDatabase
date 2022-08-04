using MigrateDatabase.Entities.Concrete.OldDb;
using System;
namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IMemberDal
    {
        List<TblMember> getMembers();
        List<IndividualMember> GetIndividualMembers();
    }
}

