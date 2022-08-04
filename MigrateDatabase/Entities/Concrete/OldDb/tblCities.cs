using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblCities : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldCountryId { get; set; }
		public string fldName { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}

