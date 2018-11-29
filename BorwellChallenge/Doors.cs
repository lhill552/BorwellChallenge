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
        private decimal height;
        private decimal width;
        private int quantity;
        private decimal area;
   

        //static decimal height1;

        public Doors(decimal newHeight, decimal newWidth, int newQuantity)
        {
            height = newHeight;
            width = newWidth;
            quantity = newQuantity;
            area = height * width * quantity;

        }

        public decimal GetArea()
        {
            return area;
        }

        public decimal GetHeight()
        {
                return height;
        }

        public decimal GetWidth() 
        {
            return width;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}
