using System;
using System.Collections.Generic;
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
        public decimal TotalPrice { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal DrawerCost { get; set; }
        public decimal MaterialCost { get; set; }
        public decimal Area { get; set; }
        public string Date { get; set; }
        public decimal OversizeCost { get; set; }
        public int ShippingIndex { get; set; }
        public int MaterialNotEmpty { get; set; }
        public int ShippingNotEmpty { get; set; }
        public int minWidth { get {return MinWidth; } }
        public int maxWidth { get { return MaxWidth; } }
        public int minDepth { get { return MinDepth; } }
        public int maxDepth { get { return MaxDepth; } }
        public decimal basePrice { get { return BASE_PRICE; } }
    }

    // Create enumerated type named DesktopMaterial

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
