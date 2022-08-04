using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess.Concrete.OldDb
{
    public class MemberBanksDal : IMemberBanksDal
    {
        public List<MemberBanks> GetMemberBanks()
        {
           using(var context = new SqlOldDbContext())
            {
                var result = from member in context.tblMember
                             join bank in context.tblBanks
                             on member.fldEnt_BankId equals bank.fldRecId

                             select new MemberBanks
                             {
                                 UserId = member.fldRecId,
                                 BankaAdi = bank.fldName,
                                 IbanNo = member.fldEnt_IBAN,
                                 KayitTarihi = member.fldCreatedOn,
                                 KayitDurumu= member.fldInv_InvestorStatus
                             };

                return result.ToList();
            }
        }
    }
}

