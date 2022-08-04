using System;
using MigrateDatabase.Entities.Abstract;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class MemberBanks:IEntity
    {
        public int? UserId { get; set; }
        public string? BankaAdi { get; set; }
        public string? IbanNo { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? KayitDurumu { get; set; }
    }
}

