using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblPreProject : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldOwnerEntrepreneurId { get; set; }
        public string fldName { get; set; }
        public string? fldDescription { get; set; }
        public int? fldProjectDevStatusId { get; set; }
        public string? fldBussinessModel { get; set; }
        public string? fldProjectTargets { get; set; }
        public string? fldEntMainCategories { get; set; }
        public string? fldProjectArea { get; set; }
        public bool? fldPreviosFunded { get; set; }
        public string? fldProjectHistory { get; set; }
        public decimal? fldFundableAmount { get; set; }
        public decimal? fldLotAmout { get; set; }
        public string? fldSunumDocFName { get; set; }
        public int? fldIncelemeDurum { get; set; }
        public string? fldIncelemeYapan { get; set; }
        public DateTime? fldIncelemeTarih { get; set; }
        public string? fldIncelemeSonuc { get; set; }
        public int? fldProjectID { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}