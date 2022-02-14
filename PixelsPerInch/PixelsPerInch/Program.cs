using System;

namespace PixelsPerInch
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        public void Start()
        {
            bool isInValidOption = true;
            string optionTxt = string.Empty;
            int option;
            bool isExit = false;
            int width, height;
            double diagonal;
            string widthTxt, diagonalTxt, heightTxt;
            bool isInValidWidth = true, isInValidDiagonal = true, isInValidHeight = true;

            do
            {
                Console.WriteLine("******* Pixels per Inch Calculator ********");
                Console.WriteLine();
                Console.WriteLine("1. Enter Screen dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("");

                do {
                    Console.Write("Please enter a valid option from the menu : ");

                    optionTxt = Console.ReadLine();

                    if (Int32.TryParse(optionTxt, out option) && ( option == 1 || option == 2 ))
                    {
                        isInValidOption = false;

                    }
                    else
                    {
                        isInValidOption = true;
                    }

                } while (isInValidOption);

                if (option == 1)
                {
                    Console.WriteLine();

                    //Get width
                    do
                    {
                        Console.Write("Please enter width : ");
                        widthTxt = Console.ReadLine();
                        if (Int32.TryParse(widthTxt, out width))
                        {
                            isInValidWidth = false;

                        }
                        else
                        {
                            isInValidWidth = true;
                            Console.WriteLine("Invalid width.");
                            Console.WriteLine();
                        }
                    } while (isInValidWidth);

                    //Get Height
                    do
                    {
                        Console.Write("Please enter height : ");
                        heightTxt = Console.ReadLine();
                        if (Int32.TryParse(heightTxt, out height))
                        {
                            isInValidHeight = false;

                        }
                        else
                        {
                            isInValidHeight = true;
                            Console.WriteLine("Invalid height.");
                            Console.WriteLine();
                        }
                    } while (isInValidHeight);


                    //Get Diagonal
                    do
                    {
                        Console.Write("Please enter Diagonal (in pixels) : ");
                        diagonalTxt = Console.ReadLine();
                        if (Double.TryParse(diagonalTxt, out diagonal))
                        {
                            isInValidDiagonal = false;

                        }
                        else
                        {
                            isInValidDiagonal = true;
                            Console.WriteLine("Invalid Diagonal.");
                            Console.WriteLine();
                        }
                    } while (isInValidDiagonal);


                    Console.WriteLine();
                    Console.WriteLine("-- Results --");
                    Console.WriteLine();

                    var result = PixelCalc.Calculate(width, height, diagonal);

                    Console.WriteLine($"PPI = {result.Ppi}");
                    Console.WriteLine($"Diagonal = {result.Diagonal} pixels");
                    Console.WriteLine($"Dot Pitch = {result.DotPitch} mm");




                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (option == 2)
                {
                    isExit = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            } while (!isExit);
        }
    }
}
