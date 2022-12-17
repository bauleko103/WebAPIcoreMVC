using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    
    public class BookModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHangHoa { get; set; }
       
        public string Mota { get; set; }
        
         
    }
    
}
