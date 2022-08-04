
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    [Table("GirisimAnaKategoriler")]
    public class GirisimAnaKategoriler:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string GirisimAnaKategoriAdi { get; set; }
    }
}

