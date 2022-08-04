
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class ProjeAnalizler:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProjeId { get; set; }
        public string GucluYonler { get; set; }
        public string ZayifYonler { get; set; }
        public string Firsatlar { get; set; }
        public string Tehditler { get; set; }
        public string NasilGuclenir { get; set; }
        public string NasilKaldirilir { get; set; }
        public string SwotUrl { get; set; }
        public string IsPlaniUrl { get; set; }
        public string SunumUrl { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public bool KayitDurumu { get; set; }
    
    }
}
