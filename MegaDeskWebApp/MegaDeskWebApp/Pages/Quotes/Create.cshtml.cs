using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWebApp.Data;
using MegaDeskWebApp.Models;

namespace MegaDeskWebApp.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWebApp.Data.MegaDeskWebAppContext _context;

        public CreateModel(MegaDeskWebApp.Data.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Quote Quote = new Quote();
            string name = Request.Form["name"];
            string width = Request.Form["width"];
            string depth = Request.Form["depth"];
            string drawerCount = Request.Form["drawercount"];
            string material = Request.Form["material"];
            int shippingIndex = Convert.ToInt32 (Request.Form["shipping"]);
            string materialIndex = Request.Form["material"];
            DateTime todayDate = DateTime.Now;
            
            // Calculate area
            var area = Int32.Parse( width) * Int32.Parse(depth);
            
            // Calculate oversize cost
            decimal oversizeCost;
            if(area > 1000)
            {
                oversizeCost = area - 1000;
            }
            else
            {
                oversizeCost = 0;
            }

            decimal materialCost;
            switch (Int32.Parse (materialIndex) )
            {
                case 1:
                    materialCost = 200;
                    break;
                case 2:
                    materialCost = 100;
                    break;
                case 3:
                    materialCost = 50;
                    break;
                case 4:
                    materialCost = 300;
                    break;
                case 5:
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;
            }

            // Calculate shipping
            int[] shipping = new int[] { 60, 70, 80, 40, 50, 60, 30, 35, 40 };

            int[,] shippingArray = new int[3, 3];

            for (int i = 0; i < shipping.Length; i++)
            {
                shippingArray[i / 3, i % 3] = shipping[i];
            }

            int shippingAreaIndex;
            switch (shippingIndex)
            {
                case 0:
                    shippingAreaIndex = 0;
                    break;
                case 1:
                    shippingAreaIndex = 1;
                    break;
                case 2:
                    shippingAreaIndex = 2;
                    break;
                case 3:
                    shippingAreaIndex = 3;
                    break;
                default:
                    shippingAreaIndex = 0;
                    break;
            }


            var shippingCost = shippingArray[shippingIndex, shippingAreaIndex];
            var drawerCost = Int32.Parse(drawerCount) * 50;
            Quote.CustomerName = name;
            Quote.Width = Int32.Parse(width);
            Quote.Depth = Int32.Parse(depth);
            Quote.Area = area;
            Quote.DrawerCount = Int32.Parse(drawerCount);
            Quote.DrawerCost = drawerCost;
            Quote.DeskMaterial = material;
            Quote.ShippingOption = Request.Form["shipping"];
            Quote.QuoteDate = todayDate;
            Quote.OversizeCost = oversizeCost;
            Quote.MaterialCost = materialCost;
            Quote.ShippingCost = shippingCost;

            // Calculate total cost
            decimal totalCost = 200 + oversizeCost + drawerCost + materialCost + shippingCost;
            Quote.TotalCost = totalCost;


            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}