using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{

    public class Users:IEntity
	{
		[Key]
		public int Id { get; set; }
		public string? Adi { get; set; }
		public string? Soyadi { get; set; }
		public string? TelefonKodu { get; set; }
		public string? TelefonNo { get; set; }
		public string? Email { get; set; }
		public bool? EmailGonderildi { get; set; }
		public bool? EmailDogrulama { get; set; }
		public string? KullaniciAdi { get; set; }
		public byte[]? PasswordSalt { get; set; }
		public byte[]? PasswordHash { get; set; }
		public bool? SosyaldenKayit { get; set; }
		public string? SosyalMedyaAdi { get; set; }
		public string? SosyalMedyaId { get; set; }
		public bool? Status { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool? KayitDurumu { get; set; }
	}

}


