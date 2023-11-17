using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA
{
    public partial class AddApt : Form
    {
        public AddApt()
        {
            InitializeComponent();
        }
        public AddApt(string customer)
        {
            InitializeComponent();
            customerBox.Text = customer;
        }

        private void addAptButton_Click(object sender, EventArgs e)
        {
            // INSERT
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
