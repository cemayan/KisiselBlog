using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KisiselBlog.Models
{
    public class Kategoriler
    {
        [Key]
        public int ID { get; set; }

        public string KategoriAdi { get; set; }


        public virtual ICollection<AltKategoriler> AltKategoriler{ get; set; }
    }
}
