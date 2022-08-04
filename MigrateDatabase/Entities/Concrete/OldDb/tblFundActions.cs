using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	public class tblFundActions : IEntity
	{
		[Key]
		public int fldRecId { get; set; }
		public int fldProjectId { get; set; }
		public int fldInvestorId { get; set; }
		public string fldPaymentNo { get; set; }
		public decimal? fldAmount { get; set; }
		public int fldPaymentTypeId { get; set; }
		public int fldBankId { get; set; }
		public DateTime? fldPaymentDate { get; set; }
		public string fldCurrencyCode { get; set; }
		public int fldStatus { get; set; }
		public string fldNotes { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }
		public bool fldQualifiedInvestor { get; set; }
	}

}