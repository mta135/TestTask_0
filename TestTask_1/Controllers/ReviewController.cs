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
            IEnumerable<Review> reviewModel = (from rev in repository.Reviews
                                               select new Review()
                                               {
                                                   Id = rev.Id,
                                                   Name = rev.Name,
                                                   Description = rev.Description,
                                                   CategoryName = rev.Category.Name
                                               });
            return View(reviewModel);
        }

        [HttpGet]
        public IActionResult AddNewReview()
        {
            ViewBag.allCategories = repository.Categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewReview(Review review)
        {
            if (ModelState.IsValid)
            {
                repository.AddNewReview(review);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.allCategories = repository.Categories;
            return View(); 
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            Review review = repository.GetReviewById(Id);
            return View(review);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Review review = repository.GetReviewById(Id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Edit(Review review)
        {
            repository.UpdateReview(review);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Review review = repository.GetReviewById(Id);
            return View(review);
        }
        [HttpPost]
        public IActionResult Delete(Review review)
        {
            repository.DeleteReview(review);
            return RedirectToAction(nameof(Index));
        }
    }
}
