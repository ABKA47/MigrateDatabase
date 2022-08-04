
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class Iller:IEntity
	{
		public int IlId { get; set; }
		public string IlAdi { get; set; }
		public int IlKodu { get; set; }
	}
}
