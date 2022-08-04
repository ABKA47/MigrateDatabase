using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjectUpdates : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldProjectId { get; set; }
        public DateTime? fldDate { get; set; }
        public string fldDescription { get; set; }
        public string fldDocFName { get; set; }
        public string fldUserName { get; set; }
        public int fldStatus { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}