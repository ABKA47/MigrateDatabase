
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class GirisimciBanka:IEntity
	{
		public int Id { get; set; }
		public int? UserId { get; set; }
		public string BankaAdi { get; set; }
		public string IbanNo { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public int? KayitDurumu { get; set; }

	}
} 
