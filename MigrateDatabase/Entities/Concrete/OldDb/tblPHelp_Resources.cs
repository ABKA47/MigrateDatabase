using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblPHelp_Resources : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public string fldRsrcType { get; set; }
		public string fldRsrcFName { get; set; }
		public string fldRsrcLink { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}

