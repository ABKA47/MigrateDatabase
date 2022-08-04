using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class tblProjectTeam : IEntity
    {
        [Key]
        public int fldRecId { get; set; }
        public int fldProjectId { get; set; }
        public string fldName { get; set; }
        public string fldSurname { get; set; }
        public string fldTCNo_VKN { get; set; }
        public string fldIdendityType { get; set; }
        public int fldCountryId { get; set; }
        public int fldCityId { get; set; }
        public int fldProvinceId { get; set; }
        public string fldAddress { get; set; }
        public string fldPhone { get; set; }
        public string fldNationality { get; set; }
        public string fldAssumedTasksDescr { get; set; }
        public string fldExpertiseDescr { get; set; }
        public string fldDealingsDescr { get; set; }
        public string fldCVDoc { get; set; }
        public string fldImage { get; set; }
        public int fldEduTitleId { get; set; }
        public string fldEMail { get; set; }
        public string fldRealationship { get; set; }
        public string fldFacebook { get; set; }
        public string fldTwitter { get; set; }
        public string fldLinkedin { get; set; }
        public string fldYouTube { get; set; }
        public string fldInstagram { get; set; }
        public DateTime? fldCreatedOn { get; set; }
        public DateTime? fldModifiedOn { get; set; }
    }
}