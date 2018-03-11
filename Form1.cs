using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declare variables
            double conversionFactor = 0.37827;
            double earthWeight;
            double marsWeight;

            try
            {
                earthWeight = Int32.Parse(txtEarthWeight.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter Numeric Value for Your Weight on Earth");
                txtEarthWeight.Text = "";
                ActiveControl = txtEarthWeight;
                return;
            }

            //Convert weight
            earthWeight = Convert.ToDouble(txtEarthWeight.Text);
            marsWeight = earthWeight * conversionFactor;

            //Update textbox with converted weight with formatting
            txtMarsWeight.Text = marsWeight.ToString("#.000");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close program
            this.Close();
        }
    }
}
