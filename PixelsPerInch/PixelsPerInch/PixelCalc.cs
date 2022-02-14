using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelsPerInch
{
    public static class PixelCalc
    {
        public static ResultObj Calculate(int width, int height, double diagonalSize)
        {
            double diagonalInPixels, ppi, dotPitch;
            
            diagonalInPixels = Math.Round(Math.Sqrt((width * width) + (height * height)), 2);

            ppi = Math.Round(diagonalInPixels / diagonalSize,2);

            dotPitch = Math.Round(25.4 / (Math.Sqrt((width * width) + (height * height)) / diagonalSize), 4);

            return new ResultObj
            {
                Ppi = ppi,
                Diagonal = diagonalInPixels,
                DotPitch = dotPitch
            };

        }
    }


    public class ResultObj : IEquatable<ResultObj>
    {

        public double Ppi { get; set; }
        public double Diagonal { get; set; }
        public double DotPitch { get; set; }

        public bool Equals(ResultObj other)
        {
            if (other is null)
            {
                return false;
            }

            return (Ppi == other.Ppi && Diagonal == other.Diagonal && DotPitch == other.DotPitch);
        }
    }
}
