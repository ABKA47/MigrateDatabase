using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class Sozlesmeler : IEntity
	{
		public int Id { get; set; }
		public string SozlesmeAdi { get; set; }
		public string SozlesmeMetin { get; set; }
		public string SozlesmeMetinLink { get; set; }
		public bool KayitDurumu { get; set; }

	}
}
