using DataAccess.Abstract;
using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
   public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
