using System;

namespace _2._2
{
    class Program
    {

        static void Main(string[] args)
        {

           
                int n;
                double[] rtn = new double[3];
                rtn[1] = 1e9;
                Console.WriteLine("请输入要输入数组的个数");
                string s = Console.ReadLine();
                n = int.Parse(s);
                int[] a = new int[n];


                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("请输入第" + i + "个数");
                    string d = Console.ReadLine();
                    a[i] = int.Parse(d);
                }
           

            for (int i = 0; i < n; i++)
            {
                if (a[i] > rtn[0]) { rtn[0] = a[i]; }
                if (a[i] < rtn[1]) { rtn[1] = a[i]; }
                rtn[2] += a[i];


            }
            Console.WriteLine($"最大值{rtn[0]},最小值{rtn[1]},和{rtn[2]},平均值{rtn[2] / n}");


        }
    }
}
