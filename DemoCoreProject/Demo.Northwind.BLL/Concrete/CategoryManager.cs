using Demo.Northwind.BLL.Abstract;
using Demo.Northwind.DAL.Abstract;
using Demo.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Northwind.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
