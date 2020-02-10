using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ds869415MIS4200940.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CustomerSince { get; set; }
        public string FullName { 
            get { return CustomerLastName + ", " + CustomerFirstName; }
                }
    }
}