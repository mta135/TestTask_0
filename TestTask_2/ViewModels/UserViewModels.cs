using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;

namespace TestTask_2.ViewModels
{
    public class UserViewModels
    {
        [Display(Name = "Full Name")]
        public string UserFulName { get; set; }
        [Display(Name = "Home Number")]
        [Range(0, 100)]
        public int HomeNumber { get; set; }

        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime UserBirthDate { get; set; }
        //[Required]
        public int CityId { get; set; }
        [Display(Name = "Cities")]
        public IEnumerable<City> Cities { get; set; }
        public IFormFile Photo { get; set; }
    }
}
