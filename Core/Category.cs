using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="The {0} is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The {0} is required")]
        public string Description { get; set; }
    }
}
