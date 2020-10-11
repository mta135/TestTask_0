using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_1.Models;

namespace TestTask_1.ViewModels
{
    public class Mapper
    {
        private static Mapper instance = null;
        private ReviewViewModels reviewViewModels;
        private static readonly object padlock = new object();
        private Mapper()
        {
        }
       
        public static Mapper Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Mapper();
                        }
                    }
                }
                return instance;
            }
        }
        public List<ReviewViewModels> ReviewModelToReviewGridViewModels(IEnumerable<Review> review)
        {
            List<ReviewViewModels> reviewViewModelsList = new List<ReviewViewModels>();
            if (review.Count() != 0)
            {
                foreach (Review item in review)
                {
                    ReviewViewModels reviewViewModels = new ReviewViewModels
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        CategoryName = item.Category.Name
                    };
                    reviewViewModelsList.Add(reviewViewModels);
                }
            }
            return reviewViewModelsList;
        }

        public ReviewViewModels MapReviewModelToReviewViewModels(Review review)
        {
            reviewViewModels = new ReviewViewModels();
            if (review != null)
            {
                reviewViewModels.Id = review.Id;
                reviewViewModels.CategoryName = review.Category.Name;
                reviewViewModels.Name = review.Name;
                reviewViewModels.Description = review.Description;
            }
            return reviewViewModels;
        }
    }
}
