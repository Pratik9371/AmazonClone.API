using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonClone.Models
{
    public class User
    {
        public Int64 ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
