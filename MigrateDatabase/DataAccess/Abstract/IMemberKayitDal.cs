using MigrateDatabase.Entities.Concrete.OldDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDatabase.DataAccess.Abstract
{
    public interface IMemberKayitDal
    {
        List<MemberKayit> GetMemberKayit();
    }
}
