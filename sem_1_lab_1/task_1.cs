using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace assignment1
{


    class task3
    {
        static public void Main()
        {
            /* 
          test scenarios
         x = 5, y = 6, z = 7
         a = 13,079181246047625, b = 0,016921997461237535
         x = 0, y = 5, z = 1
         The result is uncertain
         x = 1, y = 16, z = 0
         The result is uncertain
         x = 0, y = 54, z = 139
         The result is uncertain
         x = 81, y = 42, z = 6
         a = 84,68491150050218, b = 0,0007125515553557031
         x = 125, y = 125, z = -1500
         The result is uncertain
          */
            double x, z, y;
            double a, b;
            Console.WriteLine("Enter the number x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number z");
            z = Convert.ToDouble(Console.ReadLine());
            while (x + z == 0 || y - x == 0 || Math.Log10(Math.Abs(y - x)) == -2)
            {
                Console.WriteLine("The result is uncertain");
                Console.WriteLine("Enter the number x");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number y");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number z");
                z = Convert.ToDouble(Console.ReadLine());

            }
            a = (Math.Log10(Math.Abs(x + z))) / (1 + (Math.Log(Math.Abs(y - x)) / 2)) + 2 * y;
            while (a == 0 || z + a <= 0 || x ==0)
            {
                Console.WriteLine("The result is uncertain");
                Console.WriteLine("Enter the number x");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number y");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the number z");
                z = Convert.ToDouble(Console.ReadLine());
            }
            b = (Math.Log(a + x)) / Math.Pow(a, 2) + Math.Pow(1 / x, a);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
