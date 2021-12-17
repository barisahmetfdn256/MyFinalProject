using Entities.Cocrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);   
    }
}
