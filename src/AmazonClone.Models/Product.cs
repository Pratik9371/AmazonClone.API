using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AmazonClone.Models
{
    public class Product
    {
        public Int64 ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Info { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public Int64 Rating { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
