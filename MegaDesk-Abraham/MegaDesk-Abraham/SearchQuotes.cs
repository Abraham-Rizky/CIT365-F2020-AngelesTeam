using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace MegaDesk_Abraham
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void PopulateDataGridView()
        {

            //Use a stream reader to open a stream from the json file.
            StreamReader jsonStream = new StreamReader("../../data/quotes.json");

            //Store the entire file in one string.
            string rawJson = jsonStream.ReadToEnd();

            //Using JSON.NET convert the data stored in the string into a list of Desk objects.
            List<Desk> desks = JsonConvert.DeserializeObject<List<Desk>>(rawJson);
            string materialQuery = materialBox.SelectedItem.ToString();

            //Clear datagrid before populating.
            dgvSearchQuotes.Rows.Clear();

            //Loop through the list of desks. For each desk create a string array for the Desk's data,
            //and the add that array to dgvAllQuotes DataGridView on the ViewAllQuotes form.
            foreach (Desk desk in desks)
            {
                if (desk.SurfaceMaterial.ToString() == materialQuery)
                {
                    string[] row = {
                    desk.CustomerName
                    , desk.Date
                    , desk.SurfaceMaterial.ToString()
                    , desk.Area.ToString()
                    , desk.MaterialCost.ToString()
                    , desk.OversizeCost.ToString()
                    , desk.NumberOfDrawers.ToString()
                    , desk.DrawerCost.ToString()
                    , desk.ShippingCost.ToString()
                    , desk.TotalPrice.ToString()};

                    dgvSearchQuotes.Rows.Add(row);
                }
            }
        }

        private void returnToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSearchQuote_Click(object sender, EventArgs e)
        {
            if (materialBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Please select one of the options above.";
            }
            else
            {
                errorLabel.Text = "";
                PopulateDataGridView();
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            List<DesktopMaterial> comboList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            materialBox.DataSource = comboList;
            materialBox.SelectedIndex = -1;
        }
    }
}
