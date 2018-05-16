﻿

using Microsoft.AspNetCore.Mvc;
using SalaryCapGame.Views;
using SalaryCapGames.Views.WebViewModels;
using System.Diagnostics;

namespace SalaryCapGame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
