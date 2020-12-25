﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImpactCalculateWebApplication.Models;
using ImpactCalculateWebApplication.Models.HomeViewModels;


namespace ImpactCalculateWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //public static int result;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(List<InputDataModel> input)
        {
            IndexViewModel viewModel = new IndexViewModel();

            //viewModel.Inputs = input;

            viewModel.CalculateResults();

            return View("Result", viewModel);
        }

        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            //CreateDBContext();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void CreateNewInput()
        {
            using (var db = new ImpactCalculationDBContext())
            {


                db.Sources.Add(new SourceData()
                {
                    Air_Pressure = 1,
                    Air_Spend = 2,
                    Air_Temperature = 3,
                    Smoke_Temperature = 4,
                    Melt_Temperature = 5,
                    Viscosity = 6,
                    CO_Percentage = 7,
                    CO2_Percentage = 8,
                    O2_Percentage = 9,
                    N2_Percentage = 10
                });

                db.SaveChanges();
            }
        }
    }

   


}
