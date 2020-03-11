using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Charity.Models
{
    public class donations
    {
        [Key]
        public int DonationID { get; set; }

        [DisplayName ("Donation Amount")]
        public double donationAmount { get; set; }
        public string donationType { get; set; }

        public virtual Inventory Inventory { get; set; }
        public string InvertoryID { get; set; }

    }
}