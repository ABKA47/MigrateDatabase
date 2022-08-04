using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{

	[Table("ProjeRiskler")]
	public class ProjeRisklerForm:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int ProjeId { get; set; }
		public string ProjeRiskler { get; set; }
		public string SektorRiskler { get; set; }
		public string PayRiskler { get; set; }
		public string DigerRiskler { get; set; }
		public DateTime? KayitTarihi { get; set; }
		public bool KayitDurumu { get; set; }
	}
}
