using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask_1.Infrastructure;
using TestTask_1.Models;

namespace TestTask_1.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReview repository;
        public ReviewController(IReview repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var aaaa = repository.Reviews;
            IEnumerable<Review> revieview  = repository.Reviews;
            return View(revieview);
        }


   

        [HttpGet]
        public IActionResult AddNewReview()
        {
            var value = repository.Categories;
            ViewBag.allCategories = repository.Categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewReview(Review review)
        {
            repository.AddNewReview(review);
            return RedirectToAction(nameof(AddNewReview));
        }
    }
}
