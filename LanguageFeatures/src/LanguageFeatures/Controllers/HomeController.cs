﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<NAME MISSING>";
                decimal? price = p?.Price ?? 0;
                string category = p?.Category ?? "<NO CATEGORY>";
                string relatedName = p?.Related?.Name ?? "<NO RELATED PRODUCTS>";
                string inStock = p?.InStock ?? false ? "In Stock!" : "Out Of Stock!";
                results.Add($"Name: {name}, Price: {price}, Category: {category}, Related Product: {relatedName}");
            }

            return View(results);
        }
    }
}
