using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;
namespace KisiselBlog.Services
{
    public interface IPaylasimlarRepository
    {

        IQueryable<Paylasimlar> TumPaylasimlariGetir();

        Paylasimlar GecerliPaylasimiGetir(string id);

        int Parcala(string id);
        void PaylasimSayisiGuncelle(string id);
    }
}
