using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using KisiselBlog.Models;
using KisiselBlog.Services;
namespace KisiselBlog.Common
{
    public class Ortak: ActionFilterAttribute
    {

        private readonly KisiselBlogContext _db;

        public Ortak(KisiselBlogContext db)
        {
            _db = db;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            dynamic data = new ExpandoObject();
            data.TumKategoriler = _db.Kategoriler.Take(5).ToList();
            data.BaslicaPaylasimlar = _db.Paylasimlar.OrderByDescending(y=>y.PaylasimGorulmeSayisi).Take(5).ToList();
            data.ArsivTarih = _db.Paylasimlar.GroupBy(x=>new { Ay = x.PaylasimTarih.Value.Month,Yil =x.PaylasimTarih.Value.Year }).Select(y=>new Models.ArsivTarih.Getir{Ay =y.Key.Ay,Sayi=y.Count(),Yil=y.Key.Yil}).ToList();
            var controller = context.Controller as Controller;
            controller.ViewBag.OrtakIcerikler= data;
            base.OnActionExecuting(context);
        }
    }
}
