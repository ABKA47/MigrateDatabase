using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProvince:IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldCityId { get; set; }
        public string fldName { get; set; }
        public string fldLatitude { get; set; }
        public string fldLongitude { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldUpdatedOn { get; set; }
    }
}