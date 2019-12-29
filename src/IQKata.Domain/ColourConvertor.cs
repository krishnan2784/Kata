using System.Drawing;

namespace Kata.Domain
{
    public class ColourConvertor
    {
        public static string ToRgb(int r, int g, int b)
        {
            b = SetColour(b);
            r = SetColour(r);
            g = SetColour(g);
            var rgbColour = Color.FromArgb(r, g, b);

            return rgbColour.R.ToString("X2") + rgbColour.G.ToString("X2") + rgbColour.B.ToString("X2");
        }

        private static int SetColour(int colourValue)
        {
            if (colourValue < 0)
                return 0;
            return colourValue > 255 ? 255 : colourValue;
        }
    }
}