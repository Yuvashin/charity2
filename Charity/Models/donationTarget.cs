using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Charity.Models
{
    public class donationTarget
    {
        [Key]
        public int DonationTargetID { get; set; }
        public virtual donations donations { get; set; }
        public int DonationID { get; set; }

        //public double calcDonationTarget()
        //{
        //    var venueprice = (from ac in db.Donations
        //                      where ac.DonationID == DonationID
        //                      select ac.DonationAmount).Single();
        //    return Convert.ToDecimal(venueprice);
        //}
    }
}