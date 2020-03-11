using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Charity.Models
{
    public class sponsorMeal
    {
        [Key]
        public int SponsorMealID { get; set; }

        [Required(ErrorMessage = "Please Enter a Date")]
        [Display(Name = "Date of Event")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public DateTime time { get; set; }
        [DisplayName("Sponsor Meal Amount")]
        public double SponsorAmount { get; set; }

    }
}