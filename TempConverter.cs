using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            celciusinputTextbox.Text = ""; // clear Celcius textbox
            farenheitoutputLabel.Text = ""; // clear Farenheit textbox
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            farenheitoutputLabel.Text = ""; // clear Farenheit textbox

            // retrieve user input and convert to Farenheit                  
            try
            {
                // Convert.ToInt32 generates FormatException                 
                // if argument cannot be converted to an integer
                double celciusvalue = Convert.ToInt32(celciusinputTextbox.Text);

                // Converting from Celcius to Farenheit                  
                double farenheitvalue = (9.0 / 5.0) * celciusvalue + 32;

                // display result in textBox2                             
                farenheitoutputLabel.Text = farenheitvalue.ToString();
            } // end try  
            catch (FormatException)
            {
                MessageBox.Show("You must enter an integer for Celcius.",
                   "Invalid Number Format", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                celciusinputTextbox.Text = ""; // clear Celcius textbox
            } // end catch                                                  
        }

        private void TempConverter_Load(object sender, EventArgs e)
        {

        }

    }
}
