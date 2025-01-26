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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //Desk ouput
            widthOutput.Text = Program.deskQuotes.Last().Desk.Width.ToString();
            depthOutput.Text = Program.deskQuotes.Last().Desk.Depth.ToString();
            drawerOutput.Text = Program.deskQuotes.Last().Desk.NumDrawers.ToString();
            materialOutput.Text = Program.deskQuotes.Last().Desk.SurfaceMaterial.ToString();

            //Quote output
            nameOutput.Text = Program.deskQuotes.Last().CustomerName;
            dateOutput.Text = Program.deskQuotes.Last().QuoteDate.ToString("MMMM, dd, yyyy");
            rushOrderOutput.Text = Program.deskQuotes.Last().NumDays.ToString();
            quoteOutput.Text = Program.deskQuotes.Last().QuoteAmount.ToString("C");

        }
    }
}
