using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellChallenge
{
    class Windows
    {
        private decimal height;
        private decimal width;
        private int quantity;

        public void setDetails (decimal newHeight, decimal newWidth, int newQuantity)
        {
            height = newHeight;
            width = newWidth;
            quantity = newQuantity;
        }

        public decimal getHeight ()
        {
            return height;
        }

        public decimal getWidth()
        {
            return width;
        }

        public decimal getQuantity()
        {
            return quantity;
        }
    }
}
