using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestTask_1.Infrastructure;
using TestTask_1.Models;
using TestTask_1.ViewModels;

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

            IEnumerable<Review> reviewModel = repository.Reviews;
            List<ReviewViewModels> ReviewGridViewModels = Mapper.Instance.ReviewModelToReviewGridViewModels(reviewModel);
            return View(ReviewGridViewModels);
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
            //Review review = repository.GetReviewById(Id);
            ReviewViewModels reviewViewModels = Mapper.Instance.MapReviewModelToReviewViewModels(repository.GetReviewById(Id));
            return View(reviewViewModels);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            //Review review = repository.GetReviewById(Id);
            ReviewViewModels reviewViewModels = Mapper.Instance.MapReviewModelToReviewViewModels(repository.GetReviewById(Id));
            return View(reviewViewModels);
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
            //Review review = repository.GetReviewById(Id);
            ReviewViewModels reviewViewModels = Mapper.Instance.MapReviewModelToReviewViewModels(repository.GetReviewById(Id));
            return View(reviewViewModels);
        }
        [HttpPost]
        public IActionResult Delete(Review review)
        {
            repository.DeleteReview(review);
            return RedirectToAction(nameof(Index));
        }
    }
}
