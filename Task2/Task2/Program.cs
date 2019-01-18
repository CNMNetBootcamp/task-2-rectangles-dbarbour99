using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //setup
                float area1 = 0;
                float area2 = 0;
                float height1 = 0;
                float width1 = 0;
                float height2 = 0;
                float width2 = 0;
                string tempnum = string.Empty;
                bool isNumeric = false;

            //input

            //get height of first rectangle
            do
            {
                Console.WriteLine ("Input height of rectangle 1");
                tempnum = Console.ReadLine();
                isNumeric = float.TryParse(tempnum, out float n);
                if (isNumeric == false || n <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }
            } while (isNumeric == false);
            height1 = int.Parse(tempnum);

            //get width of first rectangle
            do
            {
                Console.WriteLine("Input width of rectangle 1");
                tempnum = Console.ReadLine();
                isNumeric = float.TryParse(tempnum, out float n);
                if (isNumeric == false || n <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }
            } while (isNumeric == false);
            width1 = int.Parse(tempnum);
            
            //get height of second rectangle
            do
            {
                Console.WriteLine("Input height of rectangle 2");
                tempnum = Console.ReadLine();
                isNumeric = float.TryParse(tempnum, out float n);
                if (isNumeric == false || n <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }
            } while (isNumeric == false);
            height2 = int.Parse(tempnum);

            //get width of second rectangle
            do
            {
                Console.WriteLine("Input width of rectangle 2");
                tempnum = Console.ReadLine();
                isNumeric = float.TryParse(tempnum, out float n);
                if (isNumeric == false || n <= 0)
                {
                    Console.WriteLine("Please enter a positive number");
                    isNumeric = false;
                }
            } while (isNumeric == false);
            width2 = int.Parse(tempnum);


            //processing
            area1 = height1 * width1;
            area2 = height2 * width2;

            //output
            if (area1 > area2)
            {
                Console.WriteLine("The area of rectangle 1 (" + area1 + ") is larger than that or rectangle 2 (" + area2 + ")");
            }
            else if (area2 > area1)
            {
                Console.WriteLine("The area of rectangle 2 (" + area2 + ") is larger than that or rectangle 1 (" + area1 + ")");
            }
            else
            {
                Console.WriteLine("The areas of both rectangles are equal (" + area1 + ")");
            }
            Console.ReadLine();
        }
    }
}
