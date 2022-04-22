using System.ComponentModel.DataAnnotations;

namespace Truyen.Models
{
    public class News
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200, MinimumLength =50)]
        public string Title { get; set; } 

        [Required]
        public string ImageUrl { get; set; } 
        
        [Required]
        [StringLength(500, MinimumLength =100)]
        public string Content { get; set; } 
        
        [Required]
        public string Author { get; set; } 

        public string CreatedAt { get; set; } 
    }
}