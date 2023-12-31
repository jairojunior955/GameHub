﻿using GameHub.ProductAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace GameHub.ProductAPI.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "The name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set;}
    }
}
