using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class Quote
    {
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Name is Required")]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Depth")]
        [Range(12, 48)]
        public int Depth { get; set; }

        [Display(Name = "Width")]
        [Range(24,96)]
        public int Width { get; set; }

        [Display(Name = "Drawer Count")]
        [Range(0, 7)]
        public int DrawerCount { get; set; }

        [Display(Name = "Material")]
        public string DeskMaterial { get; set; }

        [Display(Name = "Shipping")]
        public string ShippingOption { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public decimal Area { get; set; }
        
        [Display(Name = "Oversize Cost")]
        public decimal OversizeCost { get; set; }
        
        [Display(Name = "Material Cost")]
        public decimal MaterialCost { get; set; }

        [Display(Name = "Drawer Cost")]
        public decimal DrawerCost { get; set; }
        
        [Display(Name = "Shipping Cost")]
        public decimal ShippingCost { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }
    }
}
