
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class PlatformLogs:IEntity
	{
		public int Id { get; set; }
		public string IlkIslemId { get; set; }
		public DateTime? IslemTarihi { get; set; }
		public string SorguRefNo { get; set; }
		public string Platform { get; set; }
		public string IslemKontrolAdi { get; set; }
		public int ProjeId { get; set; }
		public int UserId { get; set; }
		public string IslemRequest { get; set; }
		public string IslemResponse { get; set; }
		public bool Basarili { get; set; }
		public string ModelAdiRequest { get; set; }
		public string ModelAdiResponse { get; set; }
	}
}
