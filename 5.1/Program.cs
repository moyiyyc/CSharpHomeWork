using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace _5._1
{
   public class Order
    {
        public static int n=1;
        public string item, itemnumber, no;
        
        public Order( string j, int k)
        {   
            this.item = j;
            this.itemnumber = Convert.ToString(k);
            this.no = j + k+ n;
            n++;

        }
             
      
    }
    public class OrderItem
    {
        public static  List<Order> orders = new List<Order>();


    }
    static public class OrderService
    {
        public static void Build(string j,int k) {
            Order order = new Order(j,k);
            OrderItem.orders.Add(order);
        
        }
        public static void Inquaire()
        {

        }
        public static void Delete() { }
        public static void Change() { }
        public static void Export( List<Order> orders)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>)) ;
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                xmlserializer.Serialize(fs, orders);
            }
            Console.WriteLine(File.ReadAllText("orders.xml"));
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入商品名，商铺");
            string a = "mianbao ";
            Console.ReadLine();
            OrderService.Build(a,10);
            OrderService.Export(OrderItem.orders);
            Console.ReadLine();
        }
    }
}
