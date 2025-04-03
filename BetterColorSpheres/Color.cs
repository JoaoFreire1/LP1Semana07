using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        public byte Red { get;}
        public byte Green { get;}
        public byte Blue { get;}
        public byte Alpha { get;}

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            Alpha = 255;
        }

        public byte GetGrey()
        {
            return (byte)((Red+Green+Blue)/3);
        }
    }
}