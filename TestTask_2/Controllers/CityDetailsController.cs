using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TestTask_2.Infrastructure;
using TestTask_2.ViewModels;

namespace TestTask_2.Controllers
{
    public class CityDetailsController : Controller
    {
        private readonly ICityDetails repository;

        public CityDetailsController(ICityDetails repository)
        {
            this.repository = repository;

        }
        [HttpGet]
        public IActionResult Index()
        {
            CityDetailsViewModel cityDetailsViewModel = new CityDetailsViewModel
            {
                Cities = repository.Cities.ToList(),
                Streets = repository.Streets.ToList()
            };
            return View(cityDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Index(CityDetailsViewModel cityDetailsViewModel)
        {
          //  repository.SaveCityDetails(cityDetailsViewModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Total()
        {
            var value = repository.CityDetails;
            return View();
        }
    }
}
