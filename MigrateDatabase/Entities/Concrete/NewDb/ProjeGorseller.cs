using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class ProjeGorseller:IEntity
    {
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public int VideoResim { get; set; }
		public string Aciklama { get; set; }
		public string GorselUrl { get; set; }
		public string VideoUrl { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }

	}
}
