using Demo.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

    }
}
