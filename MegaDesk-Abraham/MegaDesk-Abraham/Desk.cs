using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Abraham
{
    public class Desk
    {
        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;
        public const decimal BASE_PRICE = 200.00M;
        public int Depth { get; set; }
        public int Width { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }
        public string CustomerName { get; set; }
        public decimal SurfaceArea { get; set; }
        public decimal TotalPrice {
            get {
                return BASE_PRICE + MaterialCost + OversizeCost + DrawerCost + ShippingCost;
            }
        }
        public decimal ShippingCost {
            get {
                // Find current directory and list our file location inside data folder
                string currentDirectory = Directory.GetCurrentDirectory();
                string dataFolder = Path.GetDirectoryName(currentDirectory);
                string goUpOneFolder = Path.GetDirectoryName(dataFolder);
                string fileLocation = $"{goUpOneFolder}/data/rushOrderPrices.txt";

                // Fetch data into 1D array then convert to 2D array
                string[] fetchFromFileArray = File.ReadLines(fileLocation).ToArray();
                string[,] getRushOrderArray = new string[3, 3];

                for (int i = 0; i < fetchFromFileArray.Length; i++) {
                    getRushOrderArray[i / 3, i % 3] = fetchFromFileArray[i];
                }

                int areaIndex = 0;
                switch (Area) {
                    case decimal n when n < 1000: {
                            areaIndex = 0;
                            break;
                        }
                    case decimal n when (n >= 1000 && n <= 2000): {
                            areaIndex = 1;
                            break;
                        }
                    case decimal n when n < 2000: {
                            areaIndex = 2;
                            break;
                        }
                }
                if (ShippingIndex == 99)
                {
                    return 0;
                }
                else
                {
                    decimal output = Convert.ToDecimal(getRushOrderArray[ShippingIndex, areaIndex]);
                    return output;
                }
            }
        }
        
        public decimal DrawerCost {
            get { 
                return 50 * NumberOfDrawers; 
            } }
        public decimal MaterialCost {
            get {
                switch (SurfaceMaterial) {
                    case 0:
                        return 200.00M;
                    case (DesktopMaterial)1:
                        return 100.00M;
                    case (DesktopMaterial)2:
                        return 50.00M;
                    case (DesktopMaterial)3:
                        return 300.00M;
                    case (DesktopMaterial)4:
                        return 125.00M;
                    default:
                        return 0.00M;
                }
            }
        }
        public decimal Area { 
            get {
                return Depth * Width;
            } }
        public string Date { get; set; }
        public decimal OversizeCost {
            get {
                if (Area > 1000) {
                    return Convert.ToDecimal(Area - 1000);
                } else {
                    return 0;
                }
            } }
        public int ShippingIndex { get; set; }
        public int MaterialNotEmpty { get; set; }
        public int ShippingNotEmpty { get; set; }
        public int minWidth { get {return MinWidth; } }
        public int maxWidth { get { return MaxWidth; } }
        public int minDepth { get { return MinDepth; } }
        public int maxDepth { get { return MaxDepth; } }
        public decimal basePrice { get { return BASE_PRICE; } }
    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
