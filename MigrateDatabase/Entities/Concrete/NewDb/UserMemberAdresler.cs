using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class UserMemberAdresler : IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string AdresTanimi { get; set; }
		public string Adres { get; set; }
		public string Ilce { get; set; }
		public int IlceKodu { get; set; }
		public string Il { get; set; }
		public int IlKodu { get; set; }
		public string Ulke { get; set; }
		public string PostaKodu { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
