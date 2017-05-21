using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;
namespace KisiselBlog.Services
{
    public interface IKategorilerRepository
    {

        IQueryable<Kategoriler> TumKategorileriGetir();

        IQueryable<Paylasimlar> KategoriyeGorePaylasimlar(int id);

        IQueryable<Paylasimlar> AyaGorePaylasimlar(int ay,int yil);

    }
}
