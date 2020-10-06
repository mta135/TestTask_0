using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_1.DataBaseAccess;
using TestTask_1.Infrastructure;
using TestTask_1.Models;

namespace TestTask_1.Repositories
{
    public class ReviewRepository : IReview
    {
        private readonly ApplicationContext_1 context;
        public ReviewRepository(ApplicationContext_1 context)
        {
            this.context = context;
        }

        public IEnumerable<Review> Reviews
        {
            get
            {
                var value = context.Reviews;
                return context.Reviews;
                //return context.Reviews.Include(r => r.Category);
            }
        }

        public void AddReview(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
        }
    }
}
