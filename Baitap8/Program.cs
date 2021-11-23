using System;

namespace Baitap8
{
    class Program
    {
        static void Main(string[] args)
        {
            int chi_phi, doanh_thu, loi_nhuan;
            Console.WriteLine("Nhap vao chi phi");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao doanh thu");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if (doanh_thu > chi_phi)
            {
                loi_nhuan = doanh_thu - chi_phi;
                Console.WriteLine($"profit {loi_nhuan}");
            }
            else if (chi_phi > doanh_thu)
            {
                loi_nhuan = chi_phi - doanh_thu;
                Console.WriteLine($"lose {loi_nhuan}");
            }
            else
            {
                Console.WriteLine($"break even");
            }
        }
    }
}