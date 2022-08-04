using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblPHelp_Izin : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public DateTime? fldDate { get; set; }
		public string fldSubject { get; set; }
		public string fldIzinFName { get; set; }
		public string fldContent { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}

