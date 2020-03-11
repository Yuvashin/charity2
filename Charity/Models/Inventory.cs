using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Charity.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }
        public string InventoryType { get; set; }
        public string InventoryDescription { get; set; }
        public bool InventoryStatus { get; set; }
    }
}