using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public abstract class BaseClass: IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatorUserId { get; set; }
        public bool IsActive { get; set; }
    }
}
