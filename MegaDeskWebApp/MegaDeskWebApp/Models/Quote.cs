﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }

        public int Depth { get; set; }
        public int Width { get; set; }
        public int DrawerCount { get; set; }
        public string DeskMaterial { get; set; }
        public string ShippingOption { get; set; }

        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public decimal Area { get; set; }
        public decimal OversizeCost { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal DrawerCost { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal TotalCost { get; set; }
    }
}
