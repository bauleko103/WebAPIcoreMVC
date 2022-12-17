using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HocWebAPICore.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHangHoa { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHangHoa { get; set; }
        [Required]
        public string Mota { get; set; }
        [Required]
        public byte GiamGia { get; set; }
        [Required]
        [Range(0,double.MaxValue)]
        public double DonGia { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }  
    }
    
}
