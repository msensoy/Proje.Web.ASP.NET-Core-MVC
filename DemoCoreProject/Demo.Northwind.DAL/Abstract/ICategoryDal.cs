using Demo.Core.DAL;
using Demo.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.DAL.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //özel operasyonlar yapılabilir
        // store procedure , view vs. özelleşmiş işler yapılabilir.
    }
}
