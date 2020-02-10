using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ds869415MIS4200940.Models
{
    public class Pets
    {
        public int petsId { get; set; }

        public string petName { get; set; }

        public int vetId { get; set; }
        public virtual vet vet { get; set; }

        public string description { get; set; }


    }
}