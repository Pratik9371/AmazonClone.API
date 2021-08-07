using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonClone.Models
{
    public class Orders
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public List<OrderDetails> OrderDetails{ get; set; }
        public double Total { get; set; }
    }
}
