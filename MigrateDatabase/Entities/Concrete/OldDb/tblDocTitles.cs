﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblDocTitles : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldUppRecId { get; set; }
		public int fldGroupId { get; set; }
		public string fldName { get; set; }
		public int fldOrderNo { get; set; }
		public bool fldStatus { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }



	}
}
