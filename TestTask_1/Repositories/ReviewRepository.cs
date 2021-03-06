﻿using Microsoft.EntityFrameworkCore;
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
                Review dbReview = context.Reviews.FirstOrDefault(r => r.Id == review.Id);
                dbReview.Name = review.Name;
                dbReview.Description = review.Description;
                context.SaveChanges();
            } catch(Exception ex)
            {
                string exception = ex.Message;
            }
        }
        public void DeleteReview(Review review)
        {
            try
            {
                Review dbReview = context.Reviews.FirstOrDefault(r => r.Id == review.Id);
                context.Reviews.Remove(dbReview);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string exception = ex.Message;
            }
        }
    }
}
