using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblFaq : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public string fldQuestion { get; set; }
		public string fldAnswer { get; set; }
		public bool fldIsActive { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}
