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
            IEnumerable<Review> review  = repository.Reviews;
            return View(review);
        }




        [HttpGet]
        public IActionResult Create()
        {
            Review review = new Review();
            return PartialView("ReviewModalPartial", review);
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            //repository.AddReview(review);
            //return RedirectToAction(nameof(Index));

            return View();
        }
    }
}
