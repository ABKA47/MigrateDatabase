
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class KurumsalMember:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? SirketUnvani { get; set; }
        public string? VergiDairesi { get; set; }
        public string? VergiNumarasi { get; set; }
        public int? IsletmeTuruId { get; set; } 
        public int? SektorId { get; set; }
        public string? FirmaLogoUrl { get; set; }
        public string? VergiLevhasiUrl { get; set; }
        public string? ImzaSirkusuUrl { get; set; }
        public bool? KayitDurumu { get; set; }
    }
}


