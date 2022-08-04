using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class UserMemberSozlesmeler:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int SozlesmeId { get; set; }
		public bool SozlesmeOnayi { get; set; }
		public DateTime? SozlesmeKabulTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
