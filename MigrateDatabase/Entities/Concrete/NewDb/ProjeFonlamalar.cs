using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class ProjeFonlamalar:IEntity
	{ 
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public decimal? GirisimDegeri { get; set; }
		public decimal? IhtiyacOlanFonTutari { get; set; }
		public int FonKullanimSuresi { get; set; }
		public decimal? VerilecekHisse { get; set; }
		public int ToplamSatisaSunulanPayAdet { get; set; }
		public decimal? PaylarinBirimSatisFiyati { get; set; }
		public bool EkFonlama { get; set; }
		public decimal? ToplanacakEnFazlaFonMiktari { get; set; }
		public decimal? FonlamaSonrasiSermaye { get; set; }
		public decimal? PaylarinBirimNominalDegeri { get; set; }
		public decimal? FonIcinVerilecekHisseOrani { get; set; }
		public string FonalamaSonrasiOrtaklikYapisi { get; set; }
		public string GenelGerekceTemelBilgiler { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
