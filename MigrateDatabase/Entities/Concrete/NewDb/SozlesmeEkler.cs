using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class SozlesmeEkler : IEntity
	{
		public int Id { get; set; }
		public int SozlesmeId { get; set; }
		public string EkSozlesmeAdi { get; set; }
		public string EkSozlesmeMetin { get; set; }
		public string EkSozlesmeMetinLink { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
