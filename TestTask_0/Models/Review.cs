using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.Models;

namespace TestTask_0.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }


        // one to one relation
        public int? CategoryId { get; set; }
        public Category Categori { get; set; }
    }
}
