using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KisiselBlog.Services;
using KisiselBlog.Models;
using KisiselBlog.Common;

namespace KisiselBlog.Controllers
{

    [ServiceFilter(typeof(Ortak))]
    public class HomeController : Controller
    {

        readonly IPaylasimlarRepository _paylasimlarrepository;


        public HomeController(IPaylasimlarRepository paylasimlarrepository)
        {
            _paylasimlarrepository = paylasimlarrepository;
        }

        public IActionResult Index()
        {
            var data = _paylasimlarrepository.TumPaylasimlariGetir();
            return View(data);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
