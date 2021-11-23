using System;

namespace Baitap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, num;
            Console.WriteLine("Nhap vao so");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                x *= i;
            }
            Console.WriteLine($"Giai thua so {num} la {x}");
        }
    }
}