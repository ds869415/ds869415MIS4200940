using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ds869415MIS4200940.Models
{
    public class vet
    {
        public System.Guid SID { get; set; }

        [Display(Name = "Vet ID")]
        public int vetId { get; set; }

        [Display(Name = "First Name")]
        [Required (ErrorMessage ="Vet First Name Required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Vet Last Name Required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Years Worked")]
        [Required(ErrorMessage = "Vet Experience Required")]
        public int yearsWorking { get; set; }

        [Display(Name = "# of Patients")]
        [Required(ErrorMessage = "Vet # of Patients Required")]
        public int patients { get; set; }

        public string FullName
        {
            get { return lastName + ", " + firstName; }
        }
    }
}