using System;
using MigrateDatabase.ApplicationDbContext;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.Entities;
using MigrateDatabase.Entities.Concrete.OldDb;

namespace MigrateDatabase.DataAccess
{
    public class MemberDal:IMemberDal
    {
        public List<IndividualMember> GetIndividualMembers()
        {
            using (var context = new SqlOldDbContext())
            {
                var result = from member in context.tblMember
                             join academicTitle in context.tblAcademicTitles
                             on member.fldEnt_AcademicTitleId equals academicTitle.fldRecId

                             select new IndividualMember()
                             {
                                 UserId = member.fldRecId,
                                 Uyruk = member.fldNationality,
                                 Cinsiyet = member.fldGender,
                                 TcKimlikNo = member.fldTCNo_VKN,
                                 TcKimlikDogrulama = member.fldTCNoConfirmed,
                                 YabanciKimlikNo = member.fldTCNo_VKN,
                                 YabanciDogrulama = false,
                                 DogumTarihi = member.fldBirthdate,
                                 MemberImageUrl = member.fldPhoto,
                                 IdentiyType = member.fldIdendityType,
                                 MemberType = member.fldMemberType,
                                 AkademikUnvan = academicTitle.fldName,
                                 YillikGelir = member.fldInv_AnnualIncome,
                                 KayitDurumu = member.fldIsActive,
                                 BireyselMemberKayit = null

                             };

                return result.ToList();
            }
        }

        public List<TblMember> getMembers()
        {
            using (var context = new SqlOldDbContext())
            {
                var result = context.tblMember;

                return result.ToList();
            }
        }
    }
}

