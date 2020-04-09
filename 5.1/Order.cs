using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;

namespace _5._1
{
   public class Order
    {
       
        private List<OrderItem> items;
        public uint OrderId{ get; set; }
        public string Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public Order()
        {
            items = new List<OrderItem>();
            CreateTime = DateTime.Now;
        }
        public Order(uint orderId, string customer, List<OrderItem> items)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.items = (items == null) ? new List<OrderItem>() : items;
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }

        public double TotalPrice
        {
            get => items.Sum(item => item.TotalPrice);
        }

        public void AddItem(OrderItem orderItem)
        {
            if (Items.Contains(orderItem))
                throw new ApplicationException($"orderItem-{orderItem} is already existed!");
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{OrderId}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            items.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            var
            hashCode = +OrderId.GetHashCode()
             + EqualityComparer<string>.Default.GetHashCode(Customer)
            + CreateTime.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.OrderId.CompareTo(other.OrderId);
        }

    }
    




    
   
   
}
