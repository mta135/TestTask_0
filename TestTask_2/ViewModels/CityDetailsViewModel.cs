using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestTask_2.Models;

namespace TestTask_2.ViewModels
{
    public class CityDetailsViewModel
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

        [Required(ErrorMessage = "Please select a file.")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }


        public List<int> StreetsId { get; set; }
        public List<Street> Streets { get; set; }


        public CityDetail CityDetails { get; set; }
    }
}
