using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblHomePSlides : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public string fldTitle { get; set; }
		public string fldText { get; set; }
		public string fldLink { get; set; }
		public string fldButtonName { get; set; }
		public DateTime? fldStartDate { get; set; }
		public DateTime? fldEndDate { get; set; }
		public int fldOrderNo { get; set; }
		public int fldPosition { get; set; }
		public string fldImageUrl { get; set; }
		public bool fldIsActive { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }
		public string fldSlideLink { get; set; }

	}
}

