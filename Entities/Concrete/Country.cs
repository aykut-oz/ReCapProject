using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Country:BaseClass
    {
        public string Name { get; set; }
        public int ContinentId { get; set; }
        public string Code { get; set; }
        public int FlagId { get; set; }
    }
}
