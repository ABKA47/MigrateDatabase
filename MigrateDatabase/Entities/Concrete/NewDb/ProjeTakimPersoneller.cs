using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjeTakimPersoneller:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string KatilimciAdi { get; set; }
		public string KatilimciSoyadi { get; set; }
		public string KatilimciGorevi { get; set; }
		public string KatilimciResimUrl { get; set; }
		public string Aciklama { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }

	}
}
