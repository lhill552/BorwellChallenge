using System;
using System.Windows.Forms;

namespace BorwellChallenge
{
    public partial class Form1 : Form
    {
        private decimal totalWalls;
        private decimal totalDoors;
        private Doors[] AllDoors = new Doors[10];
        private Doors[] AllWalls = new Doors[10];
        private int NumDoors;
        private int NumWalls;

        public Form1()
        {
            InitializeComponent();
           
            NumDoors = -1;
            NumWalls = -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single width, length, height, area, volume, paint;
            // This section calculates the area and volume of the room depending on the users input.
            width = Convert.ToSingle(nudWidth.Text);
            length = Convert.ToSingle(nudWidth.Text);
            height = Convert.ToSingle(nudWidth.Text);


            area = (width * length);   // This is to calculate the Area of the Room based on the user input.
            volume = width * height * length;    // This is to calculate the Area of the Room based on the user input.
            paint = ((float)totalWalls - (float)totalDoors) /14;       // This calculates the amount of paint needed based on 14 meters square per a liter of paint.

            // This section shows the results based from the users input.
            lblArea.Text = "The floor area is " + Convert.ToString(area) + " m2";
            lblVolume.Text = "The volume of the room is " + Convert.ToString(volume) + " m3";
            // following section shows a message if the area of doors and windows exceed the total wall area.
            {
                if (paint <= 0)
                {
                    lblPaint.Text = " Paint needed for this room would be " + "0" + " ltr";
                    MessageBox.Show("No tins are needed");
                }
                else
                {
                    lblPaint.Text = " Paint needed for this room would be " + Convert.ToString(Math.Round(paint, 2)) + " ltr";
                }
            }



        }

        // following section is for the calculation and showing of the doors and windows details.
        private void btnAddDoor_Click(object sender, EventArgs e)
        {
            decimal newWidth = Convert.ToDecimal(nudWidth.Value);
            decimal newHeight = Convert.ToDecimal(nudHeight.Value);
            int newQuantity = Convert.ToInt32(nudQuantity.Value);

            NumDoors++;

            Doors newDoors = new Doors(newWidth, newHeight, newQuantity);
            AllDoors[NumDoors] = newDoors;
            PopulateList();
        }
        // following section is for the calculation and showing of the walls details.
        private void btnAddWall_Click(object sender, EventArgs e)
        {
            decimal newWidth = Convert.ToDecimal(nudWidth.Value);
            decimal newHeight = Convert.ToDecimal(nudHeight.Value);
            int newQuantity = Convert.ToInt32(nudQuantity.Value);

            NumWalls++;
            
            Doors newWalls = new Doors(newWidth, newHeight, newQuantity );
            AllWalls[NumWalls] = newWalls;
            PopulateList();
        }
        // this allows for the wall, door and windows details to be shown in the list box 
        private void PopulateList() 
        {
            lstWalls.Items.Clear();
            totalWalls = 0;
            for (int i = 0; i <= NumWalls; i++)
            {
                string myWidth = Convert.ToString( AllWalls[i].GetWidth());
                string myHeight = Convert.ToString(AllWalls[i].GetHeight());
                string myQuantity = Convert.ToString(AllWalls[i].GetQuantity());
                string myArea = Convert.ToString(AllWalls[i].GetArea());
                lstWalls.Items.Add("Quantity: " + myQuantity + " Width: " + myWidth + " Height: " + myHeight + " Area: " + myArea  );
                totalWalls += AllWalls[i].GetArea();
                label3.Text = "Total Wall Area: " + totalWalls.ToString();// this is to show the current area based from the wall sizing given .
            }
            lstDoors.Items.Clear();
            totalDoors = 0;
            for (int i = 0; i <= NumDoors; i++)
            {
                string myWidth = Convert.ToString(AllDoors[i].GetWidth());
                string myHeight = Convert.ToString(AllDoors[i].GetHeight());
                string myQuantity = Convert.ToString(AllDoors[i].GetQuantity());
                string myArea = Convert.ToString(AllDoors[i].GetArea());
                lstDoors.Items.Add("Quantity: " + myQuantity + " Width: " + myWidth + " Height: " + myHeight + " Area: " + myArea);
                totalDoors += AllDoors[i].GetArea();
                label4.Text = "Total Door/Window Area: " + totalDoors.ToString(); // this is to show the current area based from the door or window sizing given .
            }

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnHelpRestart_Click(object sender, EventArgs e)
        {
            string message = "If you have made a mistake click here to restart.";
            string title = "Help";
            MessageBox.Show(message, title);
        }

        private void btnHelpCalculate_Click(object sender, EventArgs e)
        {
            string message = "Click here to calculate: Area, Volume and Paint needed.";
            string title = "Help";
            MessageBox.Show(message, title);
        }

        private void btnHelpStart_Click(object sender, EventArgs e)
        {
            string message = "Please fill in the measurements below, then press either 'Add Walls' or 'Add Doors/Windows' button after. Do this for every wall,door and window in the room.";
            string title = "Help";
            MessageBox.Show(message, title);
        }
    }
}
