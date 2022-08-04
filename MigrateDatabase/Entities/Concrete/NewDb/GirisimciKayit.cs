
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class GirisimciKayit:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Meslek { get; set; }
        public string EgitimDurumu { get; set; }
        public string IsDeneyimi { get; set; }
        public string OzgecmisUrl { get; set; }
        public string BankaAdi { get; set; }
        public string IbanNo { get; set; }
        public string UzmanlikAlani { get; set; }
        public string TicariSicilNo { get; set; }
        public string TicariSicilGazetesiUrl { get; set; } 
        public int SektorId { get; set; }
        public int IsletmeTuruId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public bool KayitDurumu { get; set; }
    }
}
