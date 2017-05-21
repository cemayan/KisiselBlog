using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;
using Microsoft.AspNetCore.Http.Features;
namespace KisiselBlog.Services
{
    public class PaylasimlarRepository : IPaylasimlarRepository
    {
        private readonly KisiselBlogContext _db;

        public PaylasimlarRepository(KisiselBlogContext dbContext)
        {
            _db = dbContext;
        }

        public IQueryable<Paylasimlar> TumPaylasimlariGetir()
        {
            return _db.Paylasimlar.ToList().AsQueryable();
        }
        
        public int Parcala(string id)
        {
            var parcalanmis = id.Split('-');
            int sayi = Convert.ToInt32(parcalanmis[0]);
            return sayi;
        }


        public Paylasimlar GecerliPaylasimiGetir(string id)
        {
            int sayi = Parcala(id);
            return _db.Paylasimlar.Find(sayi);
        }




        public void PaylasimSayisiGuncelle(string id)
        {
           // int sayi = Parcala(id);

            //var data = _db.Paylasimlar.Find(4);

           // data.PaylasimGorulmeSayisi = data.PaylasimGorulmeSayisi + 1;
            //_db.SaveChanges();

        }
    }
}
