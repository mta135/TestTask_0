using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.DataBase;
using TestTask_0.Infrastructure;
using TestTask_0.Model;

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

        public void AddReview(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
