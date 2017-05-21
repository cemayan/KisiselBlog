using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KisiselBlog.Services;
using KisiselBlog.Common;

namespace KisiselBlog.Controllers
{


    [ServiceFilter(typeof(Ortak))]
    public class PaylasimlarController : Controller
    {

        readonly IPaylasimlarRepository _paylasimlarrepository;
        readonly IKategorilerRepository _kategorilerrepository;
        public PaylasimlarController(IPaylasimlarRepository paylasimlarrepository, IKategorilerRepository kategorilerrepository)
        {
            _paylasimlarrepository = paylasimlarrepository;
            _kategorilerrepository = kategorilerrepository;
        }

        public IActionResult Detay(string id)
        {
            var data = _paylasimlarrepository.GecerliPaylasimiGetir(id);
            //_paylasimlarrepository.PaylasimSayisiGuncelle(id);
            return View(data);
        }

        public IActionResult Kategori(int id)
        {
            var data = _kategorilerrepository.KategoriyeGorePaylasimlar(id);
            return View(data);
        }

        public IActionResult Arsiv(int ay,int yil)
        {
            var data = _kategorilerrepository.AyaGorePaylasimlar(ay,yil);
            return View(data);
        }
    }
}
