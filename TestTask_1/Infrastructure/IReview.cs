﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_1.Models;

namespace TestTask_1.Infrastructure
{
   public  interface IReview
    {
        IEnumerable<Review> Reviews { get; }
        IEnumerable<Category> Categories { get; }
        void AddNewReview(Review review);
        Review GetReviewById(int Id);
        void UpdateReview(Review review);
        void DeleteReview(Review review);
    }
}
