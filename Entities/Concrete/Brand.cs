using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand: BaseClass
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public int CountryId { get; set; }
    }
}
