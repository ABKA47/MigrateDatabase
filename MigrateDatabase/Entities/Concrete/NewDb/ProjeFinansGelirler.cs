using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class ProjeFinansGelirler:IEntity
    {
		public int Id { get; set; }
		public int ProjeId { get; set; }
		public int ProjeFinansId { get; set; }
		public DateTime? GelirTarihi { get; set; }
		public string Aciklama { get; set; }
		public decimal? Tutar { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }

	}
}
