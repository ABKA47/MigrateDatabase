using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjePazarHedefler:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string PazarHakkinda { get; set; }
		public string RekabetHakkinda { get; set; }
		public string HedefKitleHakkinda { get; set; }
		public string TicarilesmeVeIsPlani { get; set; }
		public string DigerDosyaAdi { get; set; }
		public string DigerBaslik { get; set; }
		public string DigerAciklama { get; set; }
		public string DigerDosyaUrl { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
