using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="The {0} is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The {0} is required"),Range(0.99,double.MaxValue,ErrorMessage ="the {0} can't be less than 0.99 pound")]
        public double Price { get; set; }
        [Required(ErrorMessage = "The {0} is required"), Range(0, int.MaxValue, ErrorMessage = "the {0} can't be less than {1} items")]
        public int Quantity { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public int? Rate { get; set; }
    }
}
