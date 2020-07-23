using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestApi.Models
{
    public class Customer
    {
        [Key]
        public int CustomerCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
 
    }
}
