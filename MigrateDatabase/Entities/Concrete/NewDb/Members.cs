
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{

    public class Member:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UyelikTipiId { get; set; }
        public string? MkkNo { get; set; }
        public bool? MkkKayit { get; set; }
        public bool? MkkNoDogrulama { get; set; }
        public bool? VknNoDogrulama { get; set; }
        public bool? YknNoDogrulama { get; set; }
        public bool? TelefonGorunmeIzni { get; set; }
        public bool? TelefonDogrulama { get; set; }
        public bool? EmailGorunmeIzni { get; set; }
        public string? WebAdresi { get; set; }  // Opsiyonel
        public bool? GirisimciSecimi { get; set; }
        public bool? GirisimciFormuDolu { get; set; }
        public bool? YatirimciSecimi { get; set; }
        public bool? YatirimciFormuDolu { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public bool? KayitDurumu { get; set; }
        public bool? GorselAdSoyadGi { get; set; }
        public bool? YatirimSayfasiGi { get; set; }
        public bool? BilgiMailiGi { get; set; }
        public bool? MemberKayit { get; set; }

    }
}



