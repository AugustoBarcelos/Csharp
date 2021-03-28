using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises1secondlist
{
    class Retangle
    {
        public double Height;
        public double Width;

        public double Area()
        {
            return Height * Width;
        }
        public double Perimeter()
        {
            return (Height * 2)+(2*Width);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Height * Height) + (Width * Width));
                ;
        }
    }
}
