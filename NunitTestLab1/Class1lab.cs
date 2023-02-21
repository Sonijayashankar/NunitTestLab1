using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestLab1
{
    internal class Class1lab
    {
        public static void Main()
        {
            int firstAngle = 0, secondAngle = 0, thirdAngle = 0;
            string customTriangle;

            Console.Write("\n\n");
            Console.Write("Check that the triangle is formed or not?\n");
            Console.Write("-------------------------------------------");

            Console.WriteLine("Enter the first angle");
            while (!int.TryParse(Console.ReadLine(), out firstAngle))
            {
                Console.WriteLine("Enter valid first angle\n");
            }

            Console.WriteLine("Enter the second angle");
            while (!int.TryParse(Console.ReadLine(), out secondAngle))
            {
                Console.WriteLine("Enter valid second angle\n");
            }

            Console.WriteLine("Enter the third angle");
            while (!int.TryParse(Console.ReadLine(), out thirdAngle))
            {
                Console.WriteLine("Enter valid third angle\n");
            }

            customTriangle = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Console.WriteLine(customTriangle);
            Console.ReadLine();
        }
    }

}

