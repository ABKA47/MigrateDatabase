using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class UserNotlar : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Note { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
