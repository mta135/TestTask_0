using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int HomeNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
