using System;
using System.Windows.Forms;

namespace MegaDesk_Abraham
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote openAddQuote = new AddQuote();
            openAddQuote.Tag = this;
            openAddQuote.Show(this);
            Hide();
        }

        private void viewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes openViewAllQuotes = new ViewAllQuotes();
            openViewAllQuotes.Tag = this;
            openViewAllQuotes.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes openSearchQuotes = new SearchQuotes();
            openSearchQuotes.Tag = this;
            openSearchQuotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
