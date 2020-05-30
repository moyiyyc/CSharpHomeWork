using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Orderapi
{
    public class OrderItem
    {
        private double orderamount;
        private double orderprice;

        public string OrderId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public double Price
        {
            get => orderprice;
            set
            {
                if (value > 0)
                {
                    orderprice = value;
                }
                else
                {
                    throw new InvalidDataException("价格不能为负");
                }
            }
        }

        [Required]
        public double Amount
        {
            get => orderamount;
            set
            {
                if (value > 0)
                {
                    orderamount = value;
                }
                else
                {
                    throw new InvalidDataException("总数不可为负");
                }
            }
        }
    }
}