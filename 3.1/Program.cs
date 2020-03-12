using System;

namespace _3._1
{
    class Program
    {
        public abstract class Shape
        {
            
            public abstract double GetArea();
            public abstract void Istrue();
        }
        class Rectangle : Shape
        {
            double x, y;
            public Rectangle(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Rectangle(double x)
            {
                this.x = x;
                this.y = x;
            }
            public override double GetArea()
            {
                double area = x * y;
                if (x == y)
                {
                    Console.WriteLine($"正方形面积为{ x * y}");
                }
                else
                {
                    Console.WriteLine($"长方形面积为{ x * y}");
                }
                return area;
            }

            public override void Istrue()
            {
                if (x >= 0 && y >= 0)
                {
                    Console.WriteLine("构建图形成立");
                }
            }
        }
        class Triangle : Shape
        {
            double x, y, z;
     
            public Triangle(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
          
            public override double GetArea()
            {
                double p = x / 2 + y / 2 + z / 2;
                double area = Math.Sqrt((1 - x) * (1 - y) * (1 - z));
                Console.WriteLine($"三角形的面积为{area}");
                return area;
            }

            public override void Istrue()
            {
                if (x + y > z && x + z > y && y + z > x)
                {
                    Console.WriteLine("此三角形成立");
                }
            }
        }

        public class ShapeFactory
        {            
            public static Shape GetShape(int n)
            {
                Random R = new Random();     
                switch (n)
                {
                    case 1:
                        return new Rectangle(R.NextDouble());
                    case 2:
                        return new Rectangle(R.NextDouble(), R.NextDouble());
                    case 3:
                        return new Triangle(R.NextDouble(), R.NextDouble(), R.NextDouble());
                    default:
                        return null;
                        
                }
               
            }
            
           
        }
        static void Main(string[] args)
        {
          
            Shape[] shapes = new Shape[10];
            double totalarea=0;
            for(int i=0; i<10;i++)
            {
                Random ran = new Random();
                int n = ran.Next(1,4);
                shapes[i] = ShapeFactory.GetShape(n);
                totalarea += shapes[i].GetArea();
               
            }
            Console.WriteLine("总面积为" + totalarea);

        }
    }
  
}

