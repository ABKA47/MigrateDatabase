using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class SiteSlayts:IEntity
	{
		public int Id { get; set; }
		public string SlaytAdi { get; set; }
		public string Url { get; set; }
		public int Sira { get; set; }
		public bool Aktif { get; set; }
	}
}
