using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this class is to gather all information which has been inserted and needs to be stored temporarily , 
//this will stay until the application has been closed.
namespace BorwellChallenge
{
    class Doors
    {
        private double height;
        private double width;
        private int quantity;
        private double area;
   

        //static decimal height1;

        public Doors(double newHeight, double newWidth, int newQuantity)
        {
            height = newHeight;
            width = newWidth;
            quantity = newQuantity;
            area = height * width * quantity;

        }

        public double GetArea()
        {
            return area;
        }

        public double GetHeight()
        {
                return height;
        }

        public double GetWidth() 
        {
            return width;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}
