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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ValidateForm(object sender, EventArgs e)
        {
            if (widthInput.Text != null && depthInput.Text != null && drawerInput.SelectedIndex >= 0 && materialInput.SelectedIndex >= 0 && nameInput.Text != null && rushOrderInput.SelectedIndex >= 0)
            {
                try
                {
                    //Create the desk and the quote
                    Desk newDesk = new Desk(int.Parse(widthInput.Text), int.Parse(depthInput.Text), int.Parse((string)drawerInput.SelectedItem), (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), materialInput.SelectedItem.ToString()));

                    DeskQuote newQuote = new DeskQuote(newDesk, (RushOrder)Enum.Parse(typeof(RushOrder), rushOrderInput.SelectedItem.ToString()), nameInput.Text, DateTime.Now);

                    Program.deskQuotes.Add(newQuote);

                    //Show the quote TODO: Bring in the new desk quote
                    DisplayQuote displayQuote = new DisplayQuote();
                    displayQuote.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter valid values. Exception: {ex}");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void ValidateWidth(object sender, CancelEventArgs e)
        {

            if (!(int.TryParse(widthInput.Text, out int inputWidth)))
            {
                MessageBox.Show("Width must be a number.");
                widthLabel.ForeColor = Color.Red;
            }
            else if (inputWidth < Desk.MIN_WIDTH || inputWidth > Desk.MAX_WIDTH)
            {
                MessageBox.Show($"Width must be between {Desk.MIN_WIDTH} and {Desk.MAX_WIDTH} inches.");
                widthLabel.ForeColor = Color.Red;
            }
            else
            {
                //Valid width
                widthLabel.ForeColor = Color.Black;
            }
        }

        private void ValidateDepth(object sender, KeyPressEventArgs e)
        {
            char[] inputChars = depthInput.Text.ToCharArray();

            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                MessageBox.Show("Depth must be a number.");
                depthInput.Text = "";
                depthLabel.ForeColor = Color.Red;
            }
            else if (inputChars.Length == 2)
            {
                int depth;
                if (int.TryParse(depthInput.Text, out depth))
                {
                    if (depth < Desk.MIN_DEPTH || depth > Desk.MAX_DEPTH)
                    {
                        MessageBox.Show($"Depth must be between {Desk.MIN_DEPTH} and {Desk.MAX_DEPTH} inches.");
                        depthLabel.ForeColor = Color.Red;
                    }
                }
            } else if (inputChars.Length > 2)
            {
                MessageBox.Show("Too many characters.");
            } else
            {
                // Valid depth
                depthLabel.ForeColor = Color.Black;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
