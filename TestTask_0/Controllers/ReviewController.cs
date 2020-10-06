using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTask_0.Infrastructure;
using TestTask_0.Model;

namespace TestTask_0.Controllers
{
    public class ReviewController : Controller
    {

        private IReview repository;

        public ReviewController(IReview repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Review> reviewList = repository.Reviews;
            return View(reviewList);
        }

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            repository.AddReview(review);
            return RedirectToAction(nameof(Index));
        }
    }
}
