using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Cocrete.EntityFramework
{
    class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
