using System;
using System.ComponentModel.DataAnnotations;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class IndividualMember:IEntity
    {
        
        public int? UserId { get; set; }
        public string? Uyruk { get; set; }
        public int? Cinsiyet { get; set; }
        public string? TcKimlikNo { get; set; }
        public bool? TcKimlikDogrulama { get; set; }
        public string? YabanciKimlikNo { get; set; }
        public bool? YabanciDogrulama { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? MemberImageUrl { get; set; }
        public string? IdentiyType { get; set; }
        public int? MemberType { get; set; }
        public string? AkademikUnvan { get; set; }
        public decimal? YillikGelir { get; set; }
        public bool? KayitDurumu { get; set; }
        public bool? BireyselMemberKayit { get; set; }
    }
}

