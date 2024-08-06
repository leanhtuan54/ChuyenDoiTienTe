using System;

namespace UngDungChuyenDoiTienTe
{
    class Program
    {
        static void Main(string[] args)
        {
            float usdCurrency;
            float vndCurrency;

            Console.Write("Enter USD currency: ");
            usdCurrency = float.Parse(Console.ReadLine());

            vndCurrency = usdCurrency*23000;

            Console.Write($"Exchange to VND currency: {vndCurrency:F2} VND");
        }
    }
}