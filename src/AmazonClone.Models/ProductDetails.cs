﻿using System.ComponentModel.DataAnnotations;

namespace AmazonClone.Models
{
    public class ProductDetails 
    {
        [Key]
        public int ID { get; set; }
        public string Detail { get; set; }
        public int ProductID { get; set; }
    }
}
