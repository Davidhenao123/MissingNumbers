using MissingNumbers.Business;
using System;
using System.Windows.Forms;

namespace MissingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IController business = new Controller();

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                String response = business.SearchMissingNumbersChain(txtInput.Text);
                txtOutput.Text = response;
            }
            catch(Exception ex)
            {
                business.WriteLog(ex.Message);
                txtOutput.Text = Business.Messages._008;
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnProcess, Titles.Titles.btnProcess);
            toolTip1.SetToolTip(this.txtInput, Titles.Titles.txtInput);
            toolTip1.SetToolTip(this.txtOutput, Titles.Titles.txtOutput);
        }
    }
}
