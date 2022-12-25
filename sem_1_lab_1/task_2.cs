using System;
namespace assingment1
{
    class task13
    {
        static public void Main()
        {
            /* test scenarios
       c = 14
       result: False century
       c = 22
       result: count = 166
       c = 45
       result: count = 165
       c = 50
       result: count = 7
       c = 65
       result: False century
         */
            Console.WriteLine("Enter a century from 16 to 50");
            int c = Convert.ToInt32(Console.ReadLine());


            if (16 <= c && c <= 50)
            {
                int count = 0;
                int d = 13;


                if (c == 16)
                {
                    for (int year = 1582; year < 1600; year++)
                    {
                        int y = year % 100, x = year / 100;
                        for (int m = 11, n = 0; n != 1; m++)
                        {
                            if (m == 13)
                            {
                                m = 1;
                            }
                            else if (m == 10)
                            {
                                n = 1;
                            }

                            int res = Math.Abs((int)(((2.6 * m - 0.2) + d + y + (y / 4) + (x / 4) - (2 * x)) % 7));
                            if (res == 5)
                            {
                                count++;
                            }
                        }
                    }
                }

                else if (c == 50)
                {
                    for (int year = 4900; year <= 4902; year++)
                    {
                        int y = year % 100, x = year / 100;
                        for (int m = 11, n = 0; n != 1; m++)
                        {
                            if (m == 13)
                            {
                                m = 1;
                            }
                            else if (m == 10)
                            {
                                n = 1;
                            }

                            int res = Math.Abs((int)(((2.6 * m - 0.2) + d + y + (y / 4) + (x / 4) - (2 * x)) % 7));
                            if (res == 5)
                            {
                                count++;
                            }
                        }
                    }
                }

                else
                {
                    for (int year = (c - 1) * 100; year < c * 100; year++)
                    {
                        int y = year % 100, x = year / 100;
                        for (int m = 11, n = 0; n != 1; m++)
                        {
                            if (m == 13)
                            {
                                m = 1;
                            }
                            else if (m == 10)
                            {
                                n = 1;
                            }

                            int res = Math.Abs((int)(((2.6 * m - 0.2) + d + y + (y / 4) + (x / 4) - (2 * x)) % 7));
                            if (res == 5)
                            {
                                count++;
                            }
                        }
                    }
                }

                Console.WriteLine("The number of Fridays falling on the 13th - " + count);
            }
            else
            {
                Console.WriteLine("False century");
            }
        }
    }
}
