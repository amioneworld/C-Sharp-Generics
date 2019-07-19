using System;
using System.Collections.Generic;
using System.Text;

namespace HowToUseAutoMapper
{
    public class Order
    {
        public int Id { get; set; }
        public LineItem Item { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
