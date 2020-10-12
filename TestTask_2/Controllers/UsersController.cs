using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask_2.Infrastructure;
using TestTask_2.Models;
using TestTask_2.ViewModels;

namespace TestTask_2.Controllers
{
    public class UsersController : Controller
    {
        private readonly ICity repository;
        public UsersController(ICity repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            UserViewModels userViewModels = new UserViewModels
            {
                Cities = repository.Cities.ToList()
            };
            return View(userViewModels);
        }

        [HttpPost] 
        public IActionResult Index(UserViewModels userViewModels)
        {
            var value = 1;
            // return View();
            return RedirectToAction(nameof(Index));
        }
    }
}
