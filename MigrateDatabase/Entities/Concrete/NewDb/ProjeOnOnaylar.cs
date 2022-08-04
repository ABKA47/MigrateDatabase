using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{ 
    public class ProjeOnOnaylar:IEntity
    {
		public int Id { get; set; }
		public int UserId { get; set; }
		public int GirimciKayitId { get; set; }
		public string ProjeLogoUrl { get; set; }
		public string GirisimAdi { get; set; }
		public string ProjeAdi { get; set; }
		public int FonToplamaTuruId { get; set; }
		public string Slogan { get; set; }
		public string ProjeKisaTanimi { get; set; }
		public string ProjeHakkinda { get; set; }
		public int GirisimAsamasiId { get; set; }
		public int GirisimModeliId { get; set; }
		public int HedefPazarId { get; set; }
		public int GirisimAnaKategoriId { get; set; }
		public int ProjeSektoruId { get; set; }
		public bool DahaOnceFonlama { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool OnayaGonder { get; set; }
		public DateTime? GuncellemeTarihi { get; set; }
		public bool KayitDurumu { get; set; }
		public int OnayDurumu { get; set; }
		public string OnayAciklama { get; set; }
		public string OnayMesaji { get; set; }
		public string ProjePath { get; set; }
	}
}
