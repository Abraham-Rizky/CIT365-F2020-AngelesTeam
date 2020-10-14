using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_Abraham
{
    

    public class DeskQuote
    {
        public const decimal BASE_PRICE = 200.00M;
        public const int DRAWER_RATE = 50;

        public string ShowDate()
        {
            String date = DateTime.Now.ToString("dd MMMM yyyy");
            return date;
        }



        public decimal GetRushOrder(int rushOption, int areaIndex)
        {
            // Find current directory and list our file location inside data folder
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.GetDirectoryName(currentDirectory);
            string goUpOneFolder = Path.GetDirectoryName(dataFolder);
            string fileLocation = $"{goUpOneFolder}/data/rushOrderPrices.txt";

            // Fetch data into 1D array then convert to 2D array
            string[] fetchFromFileArray = File.ReadLines(fileLocation).ToArray();
            string[,] getRushOrderArray= new string[3,3];
            
            for (int i=0; i<fetchFromFileArray.Length; i++)
            {
                getRushOrderArray[i/3, i%3] = fetchFromFileArray[i];
            }

            decimal output = Convert.ToDecimal ( getRushOrderArray[rushOption, areaIndex] );
            return output;
        }
    }
}
