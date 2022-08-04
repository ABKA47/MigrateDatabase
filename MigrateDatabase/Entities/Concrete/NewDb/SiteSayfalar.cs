using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class SiteSayfalar:IEntity
	{
		public int Id { get; set; }
		public string MenuAdi { get; set; }
		public string Baslik { get; set; }
		public string Sayfa { get; set; }
		public bool Aktif { get; set; }
	}
}
