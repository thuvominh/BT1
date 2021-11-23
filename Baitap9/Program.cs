using System;
using System.Linq;


namespace Baitap9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SoNguyen = {1, 4, 5, 2, 3, 4, 2, 1, 1, 6, 7, 7};
            int sum = 0;
            
            for (int i = 0; i < SoNguyen.Length; i++)
            {
                sum += SoNguyen[i];
            }
            Console.WriteLine(" Tong cac so nguyen trong mang: " + sum);
            //
            int[] disArr = intArr.Distinct().ToArray();

            for(int i=0; i<disArr.Length;i++)
            {
                int count = 0;
                for(int j=0;j<intArr.Length;j++)
                {
                    if(disArr[i] == intArr[j])
                    {
                        count++;
                    }

                }
                Console.WriteLine($"So lan xuat hien so {disArr[i]} la: {count}");
            }
        }
    }
}