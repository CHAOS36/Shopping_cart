﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter a value")]

        public string Name { get; set; }

        [Required, MinLength(4, ErrorMessage = "Minimum length is 2")]
        public string Description { get; set; }
        public String Slug { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a value")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public long CategoryId { get; set; }

        public Category Category { get; set; }

        public string Image { get; set; }
    }
}
