using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Cocrete
{
    public class Order: IEntity
    {
        public int OrderId { get; set; }
        public string CustoemrId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
