using Demo.Core.DAL.EntityFramework;
using Demo.Northwind.DAL.Abstract;
using Demo.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }


}
