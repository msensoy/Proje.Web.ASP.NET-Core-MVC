using Demo.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.BLL.Abstract
{
    public interface IProductService
    {
        Product GetbyId(int productId);
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);

    }
}
