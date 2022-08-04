
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class BireyselMember:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Uyruk { get; set; } // tr  yabanci
        public string? Cinsiyet { get; set; } // Kadın - Erkek Opsiyonel
        public string? TcKimlikNo { get; set; }
        public bool? TcKimlikDogrulama { get; set; }
        public string? YabanciKimlikNo { get; set; }
        public bool? YabanciDogrulama { get; set; } 
        public DateTime? DogumTarihi { get; set; }
        public string? MemberImageUrl { get; set; }
        public string? AkademikUnvan { get; set; } 
        public decimal? YillikGelir { get; set; }  // Opsiyonel
        public bool? KayitDurumu { get; set; }
        public bool? BireyselMemberKayit { get; set; }


    }
}

