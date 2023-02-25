using System;
namespace assingment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            double halfsum = 0;  
            double sum = 0;
            Random elemofmatrix = new Random();
            Console.WriteLine("Enter N, that is grater than number 6 and is odd to generate new matrix [N, N]:");
            N = Convert.ToInt32(Console.ReadLine());
            int K;
            Console.WriteLine("Enter the maximum allowable value of the matrix members:");
            K = Convert.ToInt32(Console.ReadLine());
            if (N < 7 || N % 2 == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            M = N;
            int[,] Matrix = new int[N, M];
            int max1 = Matrix[0, 1];
            Console.WriteLine("Generation in process...");
            Thread.Sleep(2500);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Matrix[i, j] = elemofmatrix.Next(K);
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix " + "[" + N + ", " + M + "] is generated successfully");
            Console.WriteLine("What will we do for next? Enter number 1, if you wanna ");
            Console.WriteLine("do a traversal of the matrix over the main diagonal. If");
            Console.WriteLine("you wanna do a traversal under the main diagonal, enter ");
            Console.WriteLine("number 2");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:

                    {
                        Console.WriteLine("traversal of the matrix over the main diagonal: ");
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i == 0 && j != 0)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i != 0 && i != N - 1 && j == M - 1)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if ((j - i) == 1 && i != 0 && i != N - 2)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i == 1 && j > 2 && j < M - 1)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i > 1 && i < N - 3 && j == M - 2)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if ((j - i) == 2 && j == M - 3)
                                {
                                    if (max1 < Matrix[i, j])
                                    {
                                        max1 = Matrix[i, j];
                                    }
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                    Console.WriteLine("Max element is " + max1 + "[" + i + "]" + "[" + j + "]");
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("traversal of the matrix under the main diagonal: ");
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i - j == 0)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                    sum += Matrix[i, j];
                                    halfsum = sum / 2;
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = N - 1; i >= 0; i--)
                        {
                            for (int j = M - 1; j >= 0; j--)
                            {
                                if (i == N - 1 && j != M - 1)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = N - 1; i >= 0; i--)
                        {
                            for (int j = M - 1; j >= 0; j--)
                            {
                                if (i != 0 && j == 0 && i != N - 1)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i - j == 1 && j != 0 && j < M - 2)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = N - 1; i >= 0; i--)
                        {
                            for (int j = M - 1; j >= 0; j--)
                            {
                                if (i == N - 2 && j != 0 && j < M - 3)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = N - 1; i >= 0; i--)
                        {
                            for (int j = M - 1; j >= 0; j--)
                            {
                                if (j == 1 && i > 2 && i < N - 2)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (j > 1 && j < M - 4 && i == N - 3)
                                {
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("half the sum = " + halfsum);
                        Console.WriteLine("determination of numbers less than half the sum is in progress...");
                        Thread.Sleep(2500);
                        for (int i = 0; i < N; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i - j > 0 && Matrix[i, j] < halfsum)
                                    Console.Write(Matrix[i, j] + "[" + i + "]" + "[" + j + "]" + "\t");
                            }
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
}
