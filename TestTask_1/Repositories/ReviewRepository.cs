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
                return context.Reviews.Include(r => r.Category);
            }
        }

        //Categories Table
        public IEnumerable<Category> Categories
        {
            get
            {
                return context.Categories;
            }
        }

        public void AddNewReview(Review review)
        {
            try
            {
                Review reviewAditional = new Review
                {
                    Name = review.Name,
                    Description = review.Description,
                    CategoryId = review.Category.Id
                };
                context.Reviews.Add(reviewAditional);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string exception = ex.ToString();
            }
        }

        public Review GetReviewById(int Id)
        {
            return context.Reviews.Include(r => r.Category).First(r => r.Id == Id);
        }

        public void UpdateReview(Review review)
        {
            try
            {
                // This SQL script is used because tables Category -> Review are in one to many relationship, and need to avoid Cascading UPDATE
                string query = "UPDATE Reviews SET Name = '" + review.Name + "', Description ='" + review.Description + "' WHERE Id = '" + review.Id + "'";
                //context.Update(review);
                context.Database.ExecuteSqlRaw(query);
            } catch(Exception ex)
            {
                string exception = ex.Message;
            }
        }
        public void DeleteReview(Review review)
        {
            try
            {
                // This SQL script is used because tables Category -> Review are in one to many relationship, and need to avoid Cascading DELETE
                string query = "DELETE FROM Reviews WHERE Id = '" + review.Id + "'";
                context.Database.ExecuteSqlRaw(query);
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
        }
    }
}
