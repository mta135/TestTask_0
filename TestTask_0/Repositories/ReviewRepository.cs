using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.DataBase;
using TestTask_0.Infrastructure;
using TestTask_0.Model;
using TestTask_0.Models;

namespace TestTask_0.Repositories
{
    public class ReviewRepository : IReview
    {
        private readonly ApplicationContext context;
        public ReviewRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Review> Reviews
        {
            get
            {
                return context.Reviews.Include(r => r.Category);
            }
        }
        public IEnumerable<Category> Categories
        {
            get
            {
                return context.Categories;
            }
        }
        public void AddReview(Review review)
        {
            try
            {
                Review reviewAdtional = new Review
                {
                    Name = review.Name,
                    Description = review.Description,
                    CategoryId = review.Category.Id
                };
                context.Reviews.Add(reviewAdtional);
                context.SaveChanges();
            } catch (Exception ex)
            {
                string exception = ex.ToString();
            }
        }
    }
}
