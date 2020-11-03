using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebApp.Data;
using MegaDeskWebApp.Models;

namespace MegaDeskWebApp.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskWebApp.Data.MegaDeskWebAppContext _context;

        public EditModel(MegaDeskWebApp.Data.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Quote Quote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quote = await _context.Quote.FirstOrDefaultAsync(m => m.ID == id);

            string name = Quote.CustomerName;
            string width = Convert.ToString(Quote.Width);
            string depth = Convert.ToString(Quote.Depth);
            string drawerCount = Convert.ToString(Quote.DrawerCount);
            int materialIndex;
            string myMaterial = Quote.DeskMaterial;
            string todayDate = Convert.ToString (Quote.QuoteDate);

            // Set material based on material index
            switch (myMaterial)
            {
                case "Oak":
                    materialIndex = 1;
                    break;
                case "Laminate":
                    materialIndex = 2;
                    break;
                case "Pine":
                    materialIndex = 3;
                    break;
                case "Rosewood":
                    materialIndex = 4;
                    break;
                case "Veneer":
                    materialIndex = 5;
                    break;
                default:
                    materialIndex = -1;
                    break;
            }
            Quote.DeskMaterial = Convert.ToString(materialIndex);

            int shippingIndex;
            string myShipping = Quote.ShippingOption;
            // Set shipping based on shipping index
            switch (myShipping)
            {
                case "Standard 14 Days":
                    shippingIndex = 99;
                    break;
                case "3 Days":
                    shippingIndex = 0;
                    break;
                case "5 Days":
                    shippingIndex = 1;
                    break;
                case "7 Days":
                    shippingIndex = 2;
                    break;
                default:
                    shippingIndex = -1;
                    break;
            }
            Quote.ShippingOption = Convert.ToString(shippingIndex);

            if (Quote == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Pass the values from onGetAsync to onPostAsync
            Quote Quote = new Quote();
            string name = Request.Form["name"];
            string width = Request.Form["width"];
            string depth = Request.Form["depth"];
            string drawerCount = Request.Form["drawercount"];
            string material = Request.Form["material"];
            int shippingIndex = Convert.ToInt32(Request.Form["shipping"]);
            string materialIndex = Request.Form["material"];
            //DateTime todayDate = DateTime.Now;
            DateTime todayDate = DateTime.Parse (Request.Form["date"]);
            var id = Request.Form["ID"];

            // Calculate area
            var area = Int32.Parse(width) * Int32.Parse(depth);

            // Calculate oversize cost
            decimal oversizeCost;
            if (area > 1000)
            {
                oversizeCost = area - 1000;
            }
            else
            {
                oversizeCost = 0;
            }

            decimal materialCost;
            string myMaterial;
            switch (Int32.Parse(materialIndex))
            {
                case 1:
                    materialCost = 200;
                    myMaterial = "Oak";
                    break;
                case 2:
                    materialCost = 100;
                    myMaterial = "Laminate";
                    break;
                case 3:
                    materialCost = 50;
                    myMaterial = "Pine";
                    break;
                case 4:
                    materialCost = 300;
                    myMaterial = "Rosewood";
                    break;
                case 5:
                    materialCost = 125;
                    myMaterial = "Veneer";
                    break;
                default:
                    materialCost = 0;
                    myMaterial = "";
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
            if (area < 1000)
            {
                shippingAreaIndex = 0;
            }
            else if (area > 1000 && area < 2000)
            {
                shippingAreaIndex = 1;
            }
            else if (area > 2000)
            {
                shippingAreaIndex = 2;
            }
            else
            {
                shippingAreaIndex = 0;
            }


            var shippingCost = 0;
            var myShipping = "";
            if (shippingIndex == 99)
            {
                shippingCost = 0;
                myShipping = "Standard 14 Days";
            }
            else
            {
                shippingCost = shippingArray[shippingIndex, shippingAreaIndex];
                switch (shippingIndex)
                {
                    case 0:
                        myShipping = "3 Days";
                        break;
                    case 1:
                        myShipping = "5 Days";
                        break;
                    case 2:
                        myShipping = "7 Days";
                        break;
                    default:
                        myShipping = "";
                        break;
                }
            }

            // Calculdate drawer cost at $50 each
            var drawerCost = Int32.Parse(drawerCount) * 50;

            // POST all required fields
            Quote.ID = Convert.ToInt32(id);
            Quote.CustomerName = name;
            Quote.Width = Int32.Parse(width);
            Quote.Depth = Int32.Parse(depth);
            Quote.Area = area;
            Quote.DrawerCount = Int32.Parse(drawerCount);
            Quote.DrawerCost = drawerCost;
            Quote.DeskMaterial = myMaterial;
            Quote.ShippingOption = myShipping;
            Quote.QuoteDate = todayDate;
            Quote.OversizeCost = oversizeCost;
            Quote.MaterialCost = materialCost;
            Quote.ShippingCost = shippingCost;

            // Calculate total cost
            decimal totalCost = 200 + oversizeCost + drawerCost + materialCost + shippingCost;
            Quote.TotalCost = totalCost;
            //END of transferring values//
            _context.Attach(Quote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuoteExists(Quote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QuoteExists(int id)
        {
            return _context.Quote.Any(e => e.ID == id);
        }
    }
}
