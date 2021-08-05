using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonClone.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public Cart()
        {
            Quantity = 1;
        }
    }
}
