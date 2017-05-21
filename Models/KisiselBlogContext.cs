using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;
namespace KisiselBlog.Models
{
    public class KisiselBlogContext:DbContext
    {
        public KisiselBlogContext(DbContextOptions<KisiselBlogContext> options) : base(options)
        {

        }

        public DbSet<Paylasimlar> Paylasimlar { get; set; }


        public DbSet<Kategoriler> Kategoriler { get; set; }


        public DbSet<AltKategoriler> AltKategoriler { get; set; }

    }
}
