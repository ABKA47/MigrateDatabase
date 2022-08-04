using System;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class Sektorler:IEntity
	{
		public int Id { get; set; }
		public string SektorAdi { get; set; }
	}
}
