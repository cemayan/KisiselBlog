using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KisiselBlog.Models
{
    public class AltKategoriler
    {

        [Key]
        public int ID { get; set; }

        public string AltKategoriAdi { get; set; }


        [ForeignKey("Kategoriler")]
        public int Kategori_ID { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }
    }
}
