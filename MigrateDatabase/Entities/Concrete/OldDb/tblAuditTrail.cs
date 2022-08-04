using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblAuditTrail : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public DateTime? fldDateTime { get; set; }
		public string fldScript { get; set; }
		public string fldUser { get; set; }
		public string fldAction { get; set; }
		public string fldTable { get; set; }
		public string fldField { get; set; }
		public string fldKeyValue { get; set; }
		public string fldOldValue { get; set; }
		public string fldNewValue { get; set; }

	}
}

