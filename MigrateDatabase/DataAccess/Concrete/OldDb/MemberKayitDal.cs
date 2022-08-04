using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities.Concrete.OldDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDatabase.DataAccess.Concrete.OldDb
{
    public class MemberKayitDal : IMemberKayitDal
    {
        public List<MemberKayit> GetMemberKayit()
        {
            using(var context = new SqlOldDbContext())
            {
                var result = from member in context.tblMember
                             join banka in context.tblBanks
                             on member.fldEnt_BankId equals banka.fldRecId
                             join meslek in context.tblOccupations
                             on member.fldEnt_OccupationId equals meslek.fldRecId
                             join edu in context.tblEduTitles
                             on member.fldEnt_EduTitleId equals edu.fldRecId
                          
                             select new MemberKayit
                             {
                                 UserId = member.fldRecId,
                                 Meslek = meslek.fldName,
                                 EgitimDurumu = edu.fldName,
                                 UzmanlikAlani = member.fldEnt_ExpertiseDescr,
                                 IsDeneyimi = member.fldEnt_WorkExperiences,
                                 TicariSicilNo = member.fldEnt_TaxRegNo,
                                 OzgecmisUrl = member.fldEnt_CVDoc,
                                 TicariSicilGazetesiUrl = member.fldEnt_FileTicSicilGaz,
                                 BankaAdi = banka.fldName,
                                 IbanNo = member.fldEnt_IBAN,
                                 KayitTarihi = member.fldCreatedOn,
                                 KayitDurumu = Boolean.Parse(member.fldInv_InvestorStatus.ToString())
                             };

                return result.ToList();
            }
        }
    }
}
