using Core.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<NumberOfSoldProduct> numberOfSoldProducts { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public double TotalPrice { get; set; }
        public bool IsDone { get; set; } = false;

    }
}
