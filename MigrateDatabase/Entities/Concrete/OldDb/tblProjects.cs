using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjects:IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldProjectStatus { get; set; }
        public string fldProjectCode { get; set; }
        public string fldName { get; set; }
        public string fldDescription { get; set; }
        public int fldOwnerEntrepreneurId { get; set; }
        public string fldFundAmountDescr { get; set; }
        public string fldCoverImg { get; set; }
        public string fldEntParticipants { get; set; }
        public string fldBussinessModel { get; set; }
        public string fldEntMainCategories { get; set; }
        public bool fldPreviosFunded { get; set; }
        public string fldProjectHistory { get; set; }
        public string fldCompanyName { get; set; }
        public int fldProjectDevStatusId { get; set; }
        public string fldProjectSlogan { get; set; }
        public string fldProjectArea { get; set; }
        public string fldProjectTargets { get; set; }
        public string fldRiskDescription1 { get; set; }
        public string fldRiskDescription2 { get; set; }
        public string fldRiskDescription3 { get; set; }
        public string fldRiskDescription4 { get; set; }
        public string fldFinanceDescription1 { get; set; }
        public string fldFinanceDescription2 { get; set; }
        public string fldFinanceDescription3 { get; set; }
        public string fldFinanceDescription4 { get; set; }
        public string fldFinanceDescription5 { get; set; }
        public string fldFinanceDescription6 { get; set; }
        public string fldFinanceDescription7 { get; set; }
        public string fldUrunHizmetDescr1 { get; set; }
        public string fldUrunHizmetDescr2 { get; set; }
        public string fldUrunHizmetDescr3 { get; set; }
        public string fldUrunHizmetDescr4 { get; set; }
        public string fldUrunHizmetDescr5 { get; set; }
        public string fldMarketingDescr1 { get; set; }
        public string fldMarketingDocFName1 { get; set; }
        public string fldMarketingDescr2 { get; set; }
        public string fldMarketingDocFName2 { get; set; }
        public string fldMarketingDescr3 { get; set; }
        public string fldMarketingDocFName3 { get; set; }
        public string fldMarketingDescr4 { get; set; }
        public string fldMarketingDocFName4 { get; set; }
        public string fldAnalysis1 { get; set; }
        public string fldAnalysis2 { get; set; }
        public string fldAnalysis3 { get; set; }
        public string fldAnalysis4 { get; set; }
        public string fldAnalysis5 { get; set; }
        public string fldAnalysis6 { get; set; }
        public string fldAnalysis7 { get; set; }
        public string fldSwotDocFName { get; set; }
        public string fldIsPlanDocFName { get; set; }
        public string fldSunumDocFName { get; set; }
        public decimal? fldCompanyValue { get; set; }
        public int fldFundUseMonths { get; set; }
        public decimal? fldFundableAmount { get; set; }
        public decimal? fldLotAmout { get; set; }
        public int fldSellingLotAmout { get; set; }
        public decimal? fldPostFundCapital { get; set; }
        public decimal? fldLotSellUnitPrice { get; set; }
        public decimal? fldLotNominalValue { get; set; }
        public bool fldOverFunding { get; set; }
        public decimal? fldTotalMaxFundAmount { get; set; }
        public decimal? fldVerilecekHisseYuzde { get; set; }
        public string fldPartnershipCompare { get; set; }
        public string fldBasicInfo { get; set; }
        public string fldCompanyLoc { get; set; }
        public DateTime? fldCampaignStartDate { get; set; }
        public DateTime? fldCampaignEndDate { get; set; }
        public int fldCampaignStatusId { get; set; }
        public decimal? fldFundNominalAmount { get; set; }
        public string fldFundCollectionTypeCode { get; set; }
        public decimal? fldAdditionalFundRate { get; set; }
        public decimal? fldQualifiedFundRate { get; set; }
        public string fldPrivileges { get; set; }
        public string fldCampaignName { get; set; }
        public string fldTWS_IBAN { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
        public string fldShortDescr { get; set; }
        public decimal? fldCompanyOldValue { get; set; }
        public decimal? fldCompanyOldCapital { get; set; }
    }
}