using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] a = new bool[101];
         
            for (int i = 2; i * i <= 100; i++)
            {
                for (int b = i; b <= 100; b+= i)
                {
                    a[b] = true;
                }
            }
            for(int i = 1; i <= 100; i++)
            {
                if (!a[i])
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
