using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Junker
{
    public partial class MainMenu : Form
    {
        private Button addNewQuote;
        private Button viewQuotes;
        private Button searchQuotes;
        private Button exit;
        private PictureBox desk;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenuLoad(object sender, EventArgs e)
        {

        }

        private void OpenAddNewQuote(object sender, EventArgs e)
        {
            AddQuote newAddQuote = new AddQuote();
            newAddQuote.Show();
        }

        private void OpenViewQuotes(object sender, EventArgs e)
        {
            ViewAllQuotes newViewAllQuotes = new ViewAllQuotes();
            newViewAllQuotes.Show();
        }

        private void OpenSearchQuotes(object sender, EventArgs e)
        {
            SearchQuotes newSearchQuotes = new SearchQuotes();
            newSearchQuotes.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
