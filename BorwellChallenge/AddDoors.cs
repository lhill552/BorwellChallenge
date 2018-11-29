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
    public partial class AddDoors : Form
    {

        public AddDoors() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal height = nudHeight.Value;
            decimal width = nudWidth.Value;
            int quantity = (int)nudQuant.Value;

            //decimal newArea = new Doors;
            
            
            //newWindow.setDetails(height, width, quantity);
        }
    }
}
