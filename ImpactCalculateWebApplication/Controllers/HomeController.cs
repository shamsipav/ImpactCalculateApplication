using System;
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
        public IActionResult Index(InputDataModel input, string buttonType)
        {
            IndexViewModel viewModel = null;

            if (buttonType == "Calculate")
            {
                double result = input.Air_Pressure + input.Air_Spend;

                viewModel = new IndexViewModel
                {
                    Input = input
                };

                return View("Result", viewModel);
            }

            if (buttonType == "AddNewRow")
            {
                IndexViewModel.rowCounter++;
            }

            if (buttonType == "RemoveNewRow")
            {
                IndexViewModel.rowCounter--;
            }

            return View(new IndexViewModel());
        }

        public IActionResult Index()
        {
            //CreateDBContext();
            return View(new IndexViewModel());
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

        public void CreateDBContext()
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
