using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblMessages : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public int fldMemberId { get; set; }
		public string fldMemberMsg { get; set; }
		public DateTime? fldMemberDatetime { get; set; }
		public int fldAdminId { get; set; }
		public string fldAdminMsg { get; set; }
		public DateTime? fldAdminDatetime { get; set; }
		public int fldStatus { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }




	}
}
