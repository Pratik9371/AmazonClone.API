using System.ComponentModel.DataAnnotations;

namespace AmazonClone.Models
{
    public class OrderDetails
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
