using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ds869415MIS4200940.Models
{
    public class Pets
    {
        public System.Guid SID { get; set; }
       
        public int petsId { get; set; }

        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Pet Name Required")]
        [StringLength(20)]
        public string petName { get; set; }

        [Display(Name = "Vet ID")]
        public int vetId { get; set; }
        public virtual vet vet { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description Required")]
        [StringLength(20)]
        public string description { get; set; }


    }
}