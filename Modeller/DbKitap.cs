using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKitapTakip.Modeller
{
    public class DbKitap
    {
        public int Id { get; set; }//PK
        [MaxLength(100, ErrorMessage = "Maks 100 karakter girin.")]
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public int? KategoriId { get; set; }//FK
        public DbKategori Kategori { get; set; }
    }
}
