using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;
        public byte GetColor() => $"{GetRed()}, {GetGreen()}, {GetBlue()}, {GetAlpha()}"

        public byte GetGrey()
        {
            return (byte)((red+green+blue)/3);
        }
    }
}