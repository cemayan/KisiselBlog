using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;

namespace KisiselBlog.Services
{
  
    public class KategorilerRepository : IKategorilerRepository
    {
        private readonly KisiselBlogContext _db;

        public KategorilerRepository(KisiselBlogContext dbContext)
        {
            _db = dbContext;
        }



        public IQueryable<Paylasimlar> AyaGorePaylasimlar(int ay,int yil)
        {
            return _db.Paylasimlar.Where(x => x.PaylasimTarih.Value.Month == ay && x.PaylasimTarih.Value.Year == yil).ToList().AsQueryable();
        }

        public IQueryable<Paylasimlar> KategoriyeGorePaylasimlar(int id)
        {
            return _db.Paylasimlar.Where(x => x.Kategori_ID == id).ToList().AsQueryable();
        }

        public IQueryable<Kategoriler> TumKategorileriGetir()
        {
            return _db.Kategoriler.ToList().AsQueryable();
        }



    }
}
