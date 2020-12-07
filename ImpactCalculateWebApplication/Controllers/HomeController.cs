using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ImpactCalculateWebApplication.Models;
using ImpactCalculateWebApplication.Models.HomeViewModels;
using System.Security.AccessControl;

namespace ImpactCalculateWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static IndexViewModel viewModel;

        int originRowCount;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(double debil)
        {
            //AddInputDBData();

            viewModel.CalculateResults();

            return View("Result", viewModel);
        }

        public IActionResult Index()
        {
            viewModel = new IndexViewModel();

            //using (var db = new ImpactCalculationDBContext())
            //{
            //    viewModel.Inputs = db.Inputs.ToList();
            //    originRowCount = viewModel.Inputs.Count;
            //}

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

        

        public void AddInputDBData()
        {
            using (var db = new ImpactCalculationDBContext())
            {
                for (int i = originRowCount; i < viewModel.Inputs.Count; i++)
                {
                    db.Inputs.Add(viewModel.Inputs[i]);
                }
        
                db.SaveChanges();
            }
        }
    }

   


}
