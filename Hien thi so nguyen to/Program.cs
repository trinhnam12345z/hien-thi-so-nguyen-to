using System;

namespace Hien_thi_so_nguyen_to
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("CT HIỂN THỊ N SỐ NGUYÊN TỐ ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Nhập n :");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n} số nguyên tố đầu tiên là :");
            daySNT(n);
        }
        static void daySNT(int n)
        {
            int index = 0;
            for (int i = 2; i < 200; i++)
            {
                bool check = true;
                for (int count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= n)
                    {
                        Console.Write($"{i} ,");
                    }
                }
            }
        }
    }
}
