using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblPages : IEntity
	{
		public string fldLanguage { get; set; }
		public string fldName { get; set; }
		public string fldTitle { get; set; }
		public string fldContent { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }



	}
}

