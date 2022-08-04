using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblPHelp_Patent : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public string fldDocNo { get; set; }
		public DateTime? fldDate { get; set; }
		public string fldDescription { get; set; }
		public string fldPatentFileName { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}

