using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjectExpenses : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldFinSubGrpId { get; set; }
        public int fldProjectId { get; set; }
        public int fldValue1 { get; set; }
        public int fldValue2 { get; set; }
        public int fldValue3 { get; set; }
        public int fldValue4 { get; set; }
        public int fldValue5 { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}