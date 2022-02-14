using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelsPerInch
{
    public static class PixelCalc
    {
        public static void Calculate(int width, int height, double diagonalSize)
        {
            double diagonalInPixels, ppi, dotPitch;
            
            diagonalInPixels = Math.Round(Math.Sqrt((width * width) + (height * height)), 2);

            ppi = Math.Round(diagonalInPixels / diagonalSize,2);

            dotPitch = Math.Round(25.4 / (Math.Sqrt((width * width) + (height * height)) / diagonalSize), 4);

            Console.WriteLine($"PPI = {ppi}");
            Console.WriteLine($"Diagonal = {diagonalInPixels} pixels");
            Console.WriteLine($"Dot Pitch = {dotPitch} mm");

        }
    }
}
