using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class ProjeGeneller:IEntity
	{
		public int Id { get; set; }
		public int ProjeId { get; set; }
		public int UserId { get; set; }
		public string TanitimVideo { get; set; }
		public string TanitimMetin { get; set; }
		public bool ProjeOnayaGonder { get; set; }
		public int ProjeOnayDurumu { get; set; }
		public string ProjeOnayAciklama { get; set; }
		public string ProjeOnayMesaji { get; set; }
		public string KampanyaKodu { get; set; }
		public DateTime? BaslamaTarihi { get; set; }
		public DateTime? KapanisTarihi { get; set; }

	}
}
