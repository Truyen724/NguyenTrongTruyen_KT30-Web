using System.ComponentModel.DataAnnotations;

namespace Truyen.Models
{
    public class Category
    {

        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; } 

    }
}