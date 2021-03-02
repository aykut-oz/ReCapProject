using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImage : BaseClass
    {
        public int CarId { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
    }
}
