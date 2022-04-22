using System.ComponentModel.DataAnnotations;

namespace Truyen.Models
{
    public class comment
    {
        public int ID { get; set; }
        
        [Required]
        public string Author { get; set; } 

        [Required]
        public string Content { get; set; } 

        public string CreatedAt { get; set; } 
    }
}