using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorwellChallenge
{
    public partial class AddWindows : Form
    {
        public AddWindows()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            decimal height = nudHeight.Value;
            decimal width = nudWidth.Value;
            int quantity = (int)nudQuant.Value;

            Windows newWindow = new Windows();
            newWindow.setDetails(height, width, quantity);
        }
    }
}
