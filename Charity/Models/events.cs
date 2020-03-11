using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Charity.Models
{
    public class events
    {
        [Key]
        public int EventID { get; set; }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        [Required(ErrorMessage = "Please Enter a Date")]
        [Display(Name = "Event Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
    }
}