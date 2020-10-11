using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestTask_1.Models;

namespace TestTask_1.ViewModels
{
    public class ReviewViewModels
    {


        //Id = rev.Id,
        //    Name = rev.Name,
        //    Description = rev.Description,
        //    CategoryName = rev.Category.Name




        public int Id { get; set; }

        [DisplayName("Name of Review")]
        [Required(ErrorMessage = "Mandatory Field. Input length must be not longer than 100 characters.")]
        [StringLength(100)]
        public string Name { get; set; }

        [DisplayName("Descprition of Review")]
        [Required(ErrorMessage = "Mandatory Field. Input length must be not longer than 100 characters. ")]
        [StringLength(100)]
        public string Description { get; set; }
      //  public int CategoryId { get; set; }

        [DisplayName("All Categories")]
        public Category Category { get; set; }

        public string CategoryName { get; set; }
    }
}
