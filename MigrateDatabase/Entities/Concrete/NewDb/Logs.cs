
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
	public class Logs:IEntity
	{
		public long Id { get; set; }
		public string MessageTemplate { get; set; }
		public string Level { get; set; }
		public DateTime? TimeStamp { get;set;}
	    public string Exception { get; set; }
    }
}
