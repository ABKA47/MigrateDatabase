
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class Ilceler:IEntity
	{
		public int IlceId { get; set; }
		public int IlId { get; set; }
		public string IlceAdi { get; set; }
		public int IlceKodu { get; set; }
	}
}
