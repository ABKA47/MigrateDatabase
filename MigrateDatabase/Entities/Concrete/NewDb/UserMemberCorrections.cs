using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class UserMemberCorrections : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime? GonderimTarihi { get; set; }
		public DateTime? GecerlilikTarihi { get; set; }
		public string Token { get; set; }
		public DateTime? OnaylamaTarihi { get; set; }
		public bool Onaylandi { get; set; }
		public string Olay { get; set; }
	}
}
