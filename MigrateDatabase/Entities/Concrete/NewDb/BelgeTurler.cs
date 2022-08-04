
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.NewDb
{
    public class BelgeTurler:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string BelgeAdi { get; set; }
    }
}
