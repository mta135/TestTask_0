using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.Model;

namespace TestTask_0.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Review Review { get; set; }
    }
}
