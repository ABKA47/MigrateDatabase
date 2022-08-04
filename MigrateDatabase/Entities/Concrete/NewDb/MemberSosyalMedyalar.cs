
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class MemberSosyalMedyalar:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SosyalMedyaAdi { get; set; }
        public string SosyalMedyaAdresi { get; set; }
    }
}
