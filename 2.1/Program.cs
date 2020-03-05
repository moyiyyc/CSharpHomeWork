using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);
                if(num<=0)
                {
                    throw new Exception("需输入正数");
                }
                int n = 2;
                while(num!=1)
                {
                    if(num % n == 0)
                    {
                        num /= n;
                        Console.Write(n + " ");

                    }
                    else
                    {
                        n++;
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("出错" + e.Message);
            }
        }
    }
}
