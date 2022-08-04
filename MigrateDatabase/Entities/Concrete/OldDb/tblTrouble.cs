using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblTrouble : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldMemberId { get; set; }
        public string fldMemberFullName { get; set; }
        public string fldPhone { get; set; }
        public string fldEMail { get; set; }
        public string fldShortDescr { get; set; }
        public string fldDescription { get; set; }
        public int fldStatus { get; set; }
        public DateTime? fldProcessDate { get; set; }
        public string fldOperator { get; set; }
        public string fldConclusion { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}