using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblReqResLog : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public DateTime? fldDate { get; set; }
        public string fldRegNo { get; set; }
        public string fldMKK_TVS { get; set; }
        public string fldReqRes { get; set; }
        public string fldProjectId { get; set; }
        public string fldMemberId { get; set; }
        public string fldData { get; set; }
        public string fldRespData { get; set; }
    }
}