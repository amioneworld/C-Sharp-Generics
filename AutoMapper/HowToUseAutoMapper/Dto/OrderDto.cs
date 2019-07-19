using System;
using System.Collections.Generic;
using System.Text;

namespace HowToUseAutoMapper
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemCost { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
