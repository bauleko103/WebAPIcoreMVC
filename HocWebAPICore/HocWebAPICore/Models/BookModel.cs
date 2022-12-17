﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HocWebAPICore.Models
{
    [Table("BookModel")]
    public class BookModel 
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Ten { get; set; }
       
        public string? Mota { get; set; }
        [Range(0,double.MaxValue)]
        public double Price { get; set; }
        [Range(0,100)]
        public int SoLuong { get; set; }
    }
    
}
