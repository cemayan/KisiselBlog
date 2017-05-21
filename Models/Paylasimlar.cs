using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KisiselBlog.Models
{
    public class Paylasimlar
    {
        [Key]
        public int ID { get; set; }

        public string PaylasimBaslik { get; set; }

        public string PaylasimOzet { get; set; }

        public string PaylasimHTML { get; set; }

        public int? PaylasimGorulmeSayisi { get; set; }

        public int? PaylasimBegenmeSayisi { get; set; }

        public DateTime? PaylasimTarih { get; set; }

        public string PaylasimResim { get; set; }

        public bool PaylasimResimGorunur { get; set; }

        [ForeignKey("Kategoriler")]
        public int Kategori_ID { get; set; }


        [ForeignKey("AltKategoriler")]
        public int AltKategori_ID { get; set; }

        public virtual Kategoriler Kategoriler {get;set; }

        public virtual AltKategoriler AltKategoriler { get; set; }



    }

}
