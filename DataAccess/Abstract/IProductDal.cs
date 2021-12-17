using Core.DataAccess;
using Entities.Cocrete;
using Entities.Cocrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Code Refactori - Kodun iyileştrilmesi
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();


    }
}
