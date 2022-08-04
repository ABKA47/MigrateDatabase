using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjeBelgeler:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string BelgeTuru { get; set; }
		public string BelgeAdi { get; set; }
		public string BelgeNo { get; set; }
		public DateTime? BelgeTarihi { get; set; }
		public string Aciklama { get; set; }
		public string BelgeUrl { get; set; }
		public string BelgeRoot { get; set; }
		public DateTime? BelgeYuklemeTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
