
using MigrateDatabase.DataAccess;
using MigrateDatabase.DataAccess.Abstract;
using MigrateDatabase.DataAccess.Concrete.NewDb;
using MigrateDatabase.DataAccess.Concrete.OldDb;
using MigrateDatabase.DataAccess.NewDb;
using MigrateDatabase.DataAccess.OldDb;
using MigrateDatabase.Entities.Concrete.NewDb;

namespace MigrateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentTypeDal paymentDal = new PaymentTypeDal();
            EntMainCategoryDal mainCategoryDal = new EntMainCategoryDal();
            GirisimAnaKategorilerDal girisimAnaKategoriler = new GirisimAnaKategorilerDal();
            MemberBanksDal memberBanksDal = new MemberBanksDal();
            GirisimciBankaDal girisimciBankaDal = new GirisimciBankaDal();
            GirisimciKayitDal girisimciKayitDal = new GirisimciKayitDal();
            MemberKayitDal memberKayitDal = new MemberKayitDal();
            MemberDal memberDal = new MemberDal();
            UserDal userDal = new UserDal();
            MembersDal membersDal = new MembersDal();
            BireyselMembersDal bireyselMembersDal = new BireyselMembersDal();
            KurumsalMembersDal kurumsalMembersDal = new KurumsalMembersDal();


           // MigrateUsers(memberDal,userDal);
            MigrateMembers(memberDal, membersDal);
            MigrateBireyselMembers(memberDal, bireyselMembersDal);
            MigrateKurumsalMembers(memberDal, kurumsalMembersDal);
            //MigrateGirisimciBank(memberBanksDal, girisimciBankaDal);
            //MigrateGirisimAnaKategoriler(mainCategoryDal, girisimAnaKategoriler);
            //MigrateGirisciKayit(girisimciKayitDal, memberKayitDal);
           

        }

        private static void MigrateGirisimAnaKategoriler(IEntMainCategoryDal _mainCategoryDal,IGirisimAnaKategorilerDal _girisimAnaKategorilerDal)
        {
            foreach (var item in _mainCategoryDal.GetEntMainCategories())
            {
                var girisimAnaKategoriler = new GirisimAnaKategoriler()
                {
                    GirisimAnaKategoriAdi = item.fldName
                };

                _girisimAnaKategorilerDal.Add(girisimAnaKategoriler);
            }

        }

       private static void MigrateGirisimciBank(IMemberBanksDal _memberBanksDal,IGirisimciBankaDal _girisimciBankaDal) 
        {
            foreach (var item in _memberBanksDal.GetMemberBanks())
            {
                var girisimciBanka = new GirisimciBanka()
                {
                    UserId = item.UserId,
                    BankaAdi = item.BankaAdi,
                    IbanNo = item.IbanNo,
                    KayitTarihi = item.KayitTarihi,
                    KayitDurumu = item.KayitDurumu
                };
                _girisimciBankaDal.Add(girisimciBanka);
               
            }
        }

        private static void MigrateGirisciKayit(IGirisimciKayitDal _girisimciKayitDal,IMemberKayitDal _memberKayitDal)
        {

            foreach (var item in _memberKayitDal.GetMemberKayit())
            {
                var girisimciKayit = new GirisimciKayit()
                {
                    UserId =item.UserId,
                    Meslek=item.Meslek,
                    EgitimDurumu = item.EgitimDurumu,
                    UzmanlikAlani = item.UzmanlikAlani,
                    IsDeneyimi = item.IsDeneyimi,
                    TicariSicilNo = item.TicariSicilNo,
                    OzgecmisUrl = item.OzgecmisUrl,
                    TicariSicilGazetesiUrl = item.TicariSicilGazetesiUrl,
                    BankaAdi = item.BankaAdi,
                    IbanNo = item.IbanNo,
                    KayitTarihi = item.KayitTarihi,
                    KayitDurumu = item.KayitDurumu,
                };
                _girisimciKayitDal.Add(girisimciKayit);

            }
        }

        private static void MigrateUsers(IMemberDal _memberDal, IUserDal _userDal)
        {
           
                
        foreach (var item in _memberDal.getMembers())
        {
                for (int i = 1; i <= 1800; i++)
                {
                    if(item.fldRecId == i)
                    {
                        var user = new Users()
                        {
                            Adi = item.fldName,
                            Soyadi = item.fldSurname,
                            TelefonKodu = "+90",
                            TelefonNo = item.fldMobilePhone,
                            Email = item.fldEMail,
                            EmailGonderildi = item.fldIsActive,
                            EmailDogrulama = item.fldIsActive,
                            KullaniciAdi = null,
                            PasswordSalt = null,
                            PasswordHash = null,
                            SosyaldenKayit = false,
                            SosyalMedyaAdi = null,
                            SosyalMedyaId = null,
                            Status = item.fldIsActive,
                            KayitTarihi = item.fldCreatedOn,
                            KayitDurumu = item.fldIsActive


                        };
                        _userDal.Add(user);
                    }
                    else
                    {
                        var user = new Users()
                        {
                            Adi = null,
                            Soyadi = null,
                            TelefonKodu = null,
                            TelefonNo = null,
                            Email = null,
                            EmailGonderildi = null,
                            EmailDogrulama = null,
                            KullaniciAdi = null,
                            PasswordSalt = null,
                            PasswordHash = null,
                            SosyaldenKayit = false,
                            SosyalMedyaAdi = null,
                            SosyalMedyaId = null,
                            Status = null,
                            KayitTarihi = null,
                            KayitDurumu = null


                        };
                        _userDal.Add(user);
                    }
                   

                }

          }
            Console.WriteLine("Users eklendi.");
            
        }

        private static void MigrateMembers(IMemberDal _memberDal, IMembersDal _membersDal)
        {
            foreach (var item in _memberDal.getMembers())
            {
                var member = new Member()
                {
                    UyelikTipiId = item.fldMemberType,
                    MkkNo = item.fldMKKRegNo,
                    MkkKayit = item.fldMKKSaved,
                    MkkNoDogrulama = item.fldMKKSaved,
                    VknNoDogrulama = false,
                    YknNoDogrulama = false,
                    TelefonGorunmeIzni = false,
                    TelefonDogrulama = item.fldMobilePhoneConfirmed,
                    EmailGorunmeIzni = false,
                    WebAdresi = item.fldWebAddress,
                    GirisimciSecimi = false,
                    GirisimciFormuDolu = false,
                    YatirimciSecimi = false,
                    YatirimciFormuDolu = false,
                    KayitTarihi = item.fldCreatedOn,
                    KayitDurumu = item.fldIsActive,
                    GorselAdSoyadGi = GetUserPrefs(item.fldUserPrefs.ToCharArray()[0]),
                    YatirimSayfasiGi = GetUserPrefs(item.fldUserPrefs.ToCharArray()[1]),
                    BilgiMailiGi = true,
                    MemberKayit = null
                };
                _membersDal.Add(member);
            }
            Console.WriteLine("Members eklendi.");
        }

        private static bool GetUserPrefs(char userPref)
        {
          
            if(userPref == 0)
            {
                return false;
            }
            else if (userPref == 1)
            {
                return true;
            }
        
            return false;
        }

        private static void MigrateBireyselMembers(IMemberDal _memberDal, IBireyselMembersDal _bireyselMembersDal)
        {
            foreach (var item in _memberDal.GetIndividualMembers()) 
            {
                var bireyselMember = new BireyselMember()
                {
                    UserId = item.UserId,
                    Uyruk = GetNationality(item.Uyruk),
                    Cinsiyet = GetGender(item.Cinsiyet),
                    TcKimlikNo = GetIdentity(item.IdentiyType,item.TcKimlikNo),
                    TcKimlikDogrulama = item.TcKimlikDogrulama,
                    YabanciKimlikNo = GetIdentity(item.IdentiyType, item.YabanciKimlikNo),
                    YabanciDogrulama = false,
                    DogumTarihi = item.DogumTarihi,
                    MemberImageUrl = GetMemberImageUrl(item.MemberType,null,item.MemberImageUrl),
                    AkademikUnvan = item.AkademikUnvan,
                    YillikGelir = item.YillikGelir,
                    KayitDurumu = item.KayitDurumu,
                    BireyselMemberKayit = item.BireyselMemberKayit
                };

                _bireyselMembersDal.Add(bireyselMember);
            }
            Console.WriteLine("Bireysel Members eklendi.");
        }

        private static string? GetNationality(string nationality)
        {
            if(nationality != null)
            {
                return "Tr";
            }
            return null;
        }
        private static string GetGender(int? gender)
        {
            if(gender == 0)
            {
                return "Kadın";
            }
            return "Erkek";
        }
        private static string? GetIdentity(string? identityType,string identityNo)
        {
            if (identityType.Equals("TCKN"))
            {
                return identityNo;
            }else if (identityType.Equals("YKN"))
            {
                return identityNo;
            }
            else
            {
                return null;
            }
        }

        private static string? GetMemberImageUrl(int? memberType,string? IdentityType,string photo)
        {
            if(memberType == 1)
            {
                return photo;
            }
            else
            {
                return null;
            }
        }

        private static void MigrateKurumsalMembers(IMemberDal _memberDal,IKurumsalMembersDal _kurumsalMembersDal)
        {
            foreach (var item in _memberDal.getMembers())
            {
                var kurumsalMember = new KurumsalMember()
                {
                    UserId = item.fldRecId,
                    SirketUnvani = item.fldTitle,
                    VergiDairesi = null,
                    VergiNumarasi = item.fldTCNo_VKN,
                    IsletmeTuruId = null,
                    SektorId = null,
                    FirmaLogoUrl = GetMemberImageUrl(null, item.fldIdendityType, item.fldPhoto),
                    KayitDurumu = item.fldIsActive,
                    VergiLevhasiUrl = item.fldEnt_FileVergiLevha,
                    ImzaSirkusuUrl = item.fldEnt_FileImzaSurkusu
                };

                _kurumsalMembersDal.Add(kurumsalMember);
            }
            Console.WriteLine("Kurumsal Members eklendi.");
        }

    }
}