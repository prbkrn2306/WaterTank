using System;

namespace WaterTank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of walls ");
                int l = int.Parse(Console.ReadLine());
                //int[] a = { 5, 0, 4, 0 };
                int[] a = new int[l];
                Console.WriteLine("Height of walls");
                for (int i = 0; i < l; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                int mul_number = 0;
                int result = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    int frstval = a[i];
                    if (a[i] > 0)
                    {
                        for (int j = i + 1; j < a.Length; j++)
                        {
                            if (a[j] == 0)
                                mul_number++;
                            else
                            {
                                i = j;
                                break;
                            }
                        }
                    }
                    if (a[i] > frstval)
                        result += (a[i] + frstval - a[i]) * mul_number;
                    else
                        result += (frstval + a[i] - frstval) * mul_number;
                }

                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
