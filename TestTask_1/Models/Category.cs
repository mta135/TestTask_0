using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public Review Review { get; set; }
    }
}
