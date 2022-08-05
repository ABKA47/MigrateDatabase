using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
	[Table("tblMember")]
	public class TblMember : IEntity
	{
		[Key]
		public int fldRecId { get; set; }

		
		public int fldMemberType { get; set; }
		public string? fldTitle { get; set; }
		public string? fldName { get; set; }
		public string? fldSurname { get; set; }
		public string? fldTCNo_VKN { get; set; }
		public string? fldIdendityType { get; set; }
		public int? fldGender { get; set; }
		public int? fldCountryId { get; set; }
		public int? fldCityId { get; set; }
		public int? fldProvinceId { get; set; }
		public string? fldPostalCode { get; set; }
		public string? fldAddress { get; set; }
		public string? fldMobilePhone { get; set; }
		public string? fldPhone { get; set; }
		public string? fldNationality { get; set; }
		public string? fldPhoto { get; set; }
		public DateTime? fldBirthdate { get; set; }
		public string? fldWebAddress { get; set; }
		public string? fldFacebook { get; set; }
		public string? fldTwitter { get; set; }
		public string? fldLinkedin { get; set; }
		public string? fldYouTube { get; set; }
		public string? fldInstagram { get; set; }
		public string? fldEMail { get; set; }
		public string? fldPassword { get; set; }
		public string? fldNotes { get; set; }
		public int? fldEnt_EduTitleId { get; set; }
		public int? fldEnt_AcademicTitleId { get; set; }
		public int? fldEnt_OccupationId { get; set; }
		public string? fldEnt_ExpertiseDescr { get; set; }
		public string? fldEnt_WorkExperiences { get; set; }
		public int? fldEnt_EntrepreneurStatus { get; set; }
		public string? fldEnt_FileVergiLevha { get; set; }
		public string? fldEnt_FileTicSicilGaz { get; set; }
		public string? fldEnt_FileImzaSurkusu { get; set; }
		public string? fldEnt_CVDoc { get; set; }
		public int? fldEnt_BankId { get; set; }
		public string? fldEnt_CompanyType { get; set; }
		public string? fldEnt_CompanySector { get; set; }
		public string? fldEnt_TaxRegNo { get; set; }
		public string? fldEnt_IBAN { get; set; }
		public decimal? fldInv_AnnualIncome { get; set; }
		public string? fldInv_MKKConfirmCode { get; set; }
		public int? fldInv_InvestorStatus { get; set; }
		public bool? fldInv_QualifiedInvestor { get; set; }
		public string? fldMKKConfirmCode { get; set; }
		public string? fldMKKConfirmDescr { get; set; }
		public bool? fldTCNoConfirmed { get; set; }
		public bool? fldMobilePhoneConfirmed { get; set; }
		public string? fldMKKRegNo { get; set; }
		public bool? fldMKKSaved { get; set; }
		public bool? fldIsActive { get; set; }
		public DateTime? fldLastLoginOn { get; set; }
		public DateTime? fldCreatedOn { get; set; }
		public DateTime? fldModifiedOn { get; set; }
		public DateTime? fldPrevLoginOn { get; set; }
		public int? fldIsDeleted { get; set; }
		public string? fldUserPrefs { get; set; }
		public DateTime? fldDeleteReqDateTime { get; set; }



	}
}

