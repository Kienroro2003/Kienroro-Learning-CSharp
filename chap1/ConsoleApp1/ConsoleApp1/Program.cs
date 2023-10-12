using System;
using System.Diagnostics;

namespace App1
{
    class Program
    {
        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 100; int b = 200;
            Console.WriteLine("Truoc khi trao doi, gia tri cua a la: {0}", a);
            Console.WriteLine("Truoc khi trao doi, gia tri cua b la: {0}", b);
            swap(ref a, ref b);
            Console.WriteLine("Sau khi trao doi, gia tri cua a la: {0}", a);
            Console.WriteLine("Sau khi trao doi, gia tri cua b la: {0}", b);
            // Console.ReadLine();
            // Console.ReadKey();

        }
    }
}