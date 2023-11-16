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
    public partial class UpdateApt : Form
    {
        public UpdateApt()
        {
            InitializeComponent();
        }

        public UpdateApt(string customer, string type, string start, string end)
        {
            InitializeComponent();
            customerBox.Text = customer;
            typeBox.Text = type;
            dateBox.Text = start.ToString();
            startBox.Text = start.ToString();
            endBox.Text = end.ToString();
        }

        private void updAptButton_Click(object sender, EventArgs e)
        {
            // UPDATE
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
