using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblSettings : IEntity
    {
        [Key]
        public string fldName { get; set; }
        public string fldType { get; set; }
        public string fldValue { get; set; }
        public int fldGroupNo { get; set; }
        public string fldDescription { get; set; }
    }
}