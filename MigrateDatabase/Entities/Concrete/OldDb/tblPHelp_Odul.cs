using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblPHelp_Odul : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public DateTime? fldDate { get; set; }
		public string fldDescription { get; set; }
		public string fldGivenBy { get; set; }
		public string fldOdulFileName { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }

	}
}

