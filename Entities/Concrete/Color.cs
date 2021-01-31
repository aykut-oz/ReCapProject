using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color: BaseClass
    {
        public string Name { get; set; }
        public string HexadecimalCode { get; set; }
        public decimal PriceDifference { get; set; }
    }
}
