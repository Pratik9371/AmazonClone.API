using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AmazonClone.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ProductDetails> ProductDetails { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
