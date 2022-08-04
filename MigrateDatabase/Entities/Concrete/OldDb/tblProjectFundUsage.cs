using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjectFundUsage : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldProjectId { get; set; }
        public string fldDecsription { get; set; }
        public DateTime? fldStartDate { get; set; }
        public DateTime? fldEndDate { get; set; }
        public decimal? fldAmount { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}