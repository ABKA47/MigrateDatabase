using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDatabase.Entities.Concrete.OldDb
{
    public class MemberKayit
    {
        public int UserId { get; set; }
        public string Meslek { get; set; }

        public string EgitimDurumu { get; set; }

        public string UzmanlikAlani { get; set; }
        public string IsDeneyimi { get; set; }
        public string TicariSicilNo { get; set; }
        public string OzgecmisUrl { get; set; }
        public string TicariSicilGazetesiUrl { get; set; }
        public string BankaAdi { get; set; }
        public string IbanNo { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public bool KayitDurumu { get; set; }
    }
}
