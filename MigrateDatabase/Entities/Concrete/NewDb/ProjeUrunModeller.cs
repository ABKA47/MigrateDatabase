using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjeUrunModeller:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string OzetBilgi { get; set; }
		public string UrunHakkinda { get; set; }
		public string TespitEdilenSorun { get; set; }
		public string Cozum { get; set; }
		public string DigerOneriler { get; set; }
		public string SurecDosyaAdi { get; set; }
		public string SurecBaslik { get; set; }
		public string SurecAciklama { get; set; }
		public string SurecDosyaUrl { get; set; }
		public string DigerDosyaAdi { get; set; }
		public string DigerBaslik { get; set; }
		public string DigerAciklama { get; set; }
		public string DigerDosyaUrl { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }

	}
}
