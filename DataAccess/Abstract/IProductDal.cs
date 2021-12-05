using Core.DataAccess;
using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Code Refactori - Kodn iyileştrilmesi
    public interface IProductDal : IEntityRepository<Product>
    {
        

    }
}
