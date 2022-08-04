using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblCountries : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public string fldName { get; set; }
        public bool fldActive { get; set; }
        public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }


	}
}
