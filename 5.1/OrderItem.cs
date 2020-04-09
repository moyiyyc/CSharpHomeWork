using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _5._1
{
    public class OrderItem
    {
        public uint Index { get; set; } //序号

        public String GoodsName { get; set; }

        public uint Quantity { get; set; }

        public double Price { get; set; }

        

        public OrderItem(uint index, String goodsName, double price, uint quantity)
        {
            this.Index = index;
            this.GoodsName = goodsName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double TotalPrice
        {
            get => Price * Quantity;
        }

        public override string ToString()
        {
            return $"[编号:{Index},商品:{GoodsName},数目:{Quantity},总价:{TotalPrice}]";
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("shabi");
            var hashCode =
             Index.GetHashCode()
             + EqualityComparer<string>.Default.GetHashCode(GoodsName)+
             Quantity.GetHashCode();
            return hashCode;
        }
    }
}
