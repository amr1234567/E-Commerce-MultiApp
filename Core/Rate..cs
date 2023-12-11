using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Product Id")]
        [Required]
        public int ProductId { get; set; }
        [Display(Name ="Product Name")]
        public string? ProductName { get; set; }
        [Display(Name ="Rate Number"),Required,Range(0,5,ErrorMessage ="The {0} must be between {1} and {2}")]
        public double RateNum { get; set; }
        [StringLength(200,ErrorMessage ="the {0} must be less then {1} chars")]
        public string Comment { get; set; } = string.Empty;
        

    }
}
