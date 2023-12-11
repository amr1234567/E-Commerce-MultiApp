using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto
{
    public class NumberOfSoldProduct
    {
        [Required]
        public int SoldAmount { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}
