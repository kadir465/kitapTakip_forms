using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKitapTakip.Modeller
{
    public class DbKategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public List<DbKitap> Kitaplar { get; set; } = new();
    }
}
