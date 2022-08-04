using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjectDocs : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldProjectId { get; set; }
        public int fldDocTitleId { get; set; }
        public string fldDocFName { get; set; }
        public string fldDocType { get; set; }
        public int fldDocSize { get; set; }
        public string fldContent { get; set; }
        public string fldDocHeading { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}