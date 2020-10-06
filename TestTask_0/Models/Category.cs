using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestTask_0.Model;

namespace TestTask_0.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public Review Review { get; set; }
    }
}
