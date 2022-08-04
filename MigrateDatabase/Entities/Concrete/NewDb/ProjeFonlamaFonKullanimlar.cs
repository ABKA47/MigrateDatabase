using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class ProjeFonlamaFonKullanimlar:IEntity
	{
		public int Id { get; set; }
		public int ProjeId { get; set; }
		public int ProjeFonlamaId { get; set; }
		public DateTime? BaslangicTarihi { get; set; }
		public DateTime? BitisTarihi { get; set; }
		public decimal? Tutar { get; set; }
		public string Aciklama { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
