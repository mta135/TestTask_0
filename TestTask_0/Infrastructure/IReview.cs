using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.Model;

namespace TestTask_0.Infrastructure
{
    public interface IReview
    {
        IEnumerable<Review> Reviews {get;}
        void AddReview(Review review);
    }
}
