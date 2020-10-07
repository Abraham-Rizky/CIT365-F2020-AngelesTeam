using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Abraham
{
    class DeskQuote
    {
        public decimal area;
        public decimal oversizeCost { get; set; }
        public decimal drawerCost;
        public decimal materialCost;
        public decimal shippingCost;
        public decimal totalPrice;
        public const decimal BASE_PRICE = 200.00M;
        public const int DRAWER_RATE = 50;

        public decimal CalcOversizeCost(decimal width, decimal depth)
        {
            Desk desk = new Desk();
            area = width * depth;
            if (area > 1000)
            {
                oversizeCost = Convert.ToDecimal( area - 1000) ;
                desk.OversizeCost = oversizeCost;
                return desk.OversizeCost;
            }
            else
            {
                oversizeCost = 0;
                return oversizeCost;
            }
        }

        public decimal CalcDrawerCost( int numberOfDrawers)
        {
            Desk desk = new Desk();
            drawerCost = numberOfDrawers * DRAWER_RATE;
            desk.DrawerCost = drawerCost;
            return desk.DrawerCost;
        }

        public decimal CalcMaterialCost(int index)
        {
           
            switch (index)
            {
                case 1:
                    materialCost = 200.00M;
                    return materialCost;
                case 2:
                    materialCost = 100.00M;
                    return materialCost;
                case 3:
                    materialCost = 50.00M;
                    return materialCost;
                case 4:
                    materialCost = 300.00M;
                    return materialCost;
                case 5:
                    materialCost = 125.00M;
                    return materialCost;
                default:
                    materialCost = 0.00M;
                    return materialCost;
            }

        }

        public decimal CalcShipping(int index, decimal width, decimal depth)
        {
            Desk desk = new Desk();
            area = width * depth;
            desk.Area = area;
            
            if (index == 0)
            {
                return desk.ShippingCost = 0.00M;
            }
            else if (index == 1)
            {
                if(area < 1000)
                {
                    shippingCost = 60.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 70.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else
                {
                    shippingCost = 80.00M;
                    return desk.ShippingCost = shippingCost;
                }
            }
            else if( index == 2)
            {
                if (area < 1000)
                {
                    shippingCost = 40.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 50.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else
                {
                    shippingCost = 60.00M;
                    return desk.ShippingCost = shippingCost;
                }
            }
            else if(index == 3)
            {
                if (area < 1000)
                {
                    shippingCost = 30.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else if (area > 1000 && area < 2000)
                {
                    shippingCost = 35.00M;
                    return desk.ShippingCost = shippingCost;
                }
                else
                {
                    shippingCost = 40.00M;
                    return desk.ShippingCost = shippingCost;
                }
            } else
            {
                return desk.ShippingCost = shippingCost;
            }
        }


        public string ShowDate()
        {
            String date = DateTime.Now.ToString("dd MMMM yyyy");
            return date;
        }



        public string GetRushOrder(int rushOption, int areaSize)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.GetDirectoryName(currentDirectory);
            string goUpOneFolder = Path.GetDirectoryName(dataFolder);
            string fileLocation = $"{goUpOneFolder}/data/rushOrderPrices.txt";
            string[] fetchFromFileArray = File.ReadLines(fileLocation).ToArray();
            string[,] getRushOrderArray= new string[3,3];
            
            for (int i=0; i<fetchFromFileArray.Length; i++)
            {
                getRushOrderArray[i/3, i%3] = fetchFromFileArray[i];
            }
            string output = getRushOrderArray[rushOption, areaSize];
            return output;
        }
    }
}
