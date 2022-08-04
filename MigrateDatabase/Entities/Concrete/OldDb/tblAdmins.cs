using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblAdmins : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public string fldName { get; set; }
		public string fldSurname { get; set; }
		public string fldMobil { get; set; }
		public string fldPhoto { get; set; }
		public string fldEMail { get; set; }
		public string fldPassword { get; set; }
		public bool fldStatus { get; set; }
		public int fldLevelId { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }

	}
}
