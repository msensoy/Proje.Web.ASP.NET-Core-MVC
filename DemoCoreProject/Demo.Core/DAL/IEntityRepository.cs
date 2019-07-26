using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Core.DAL
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
        // oluşan interface generiktir       
        // where sayesinde : t bir referans tipte olmalıdır(class) , ve new lenebilir olmalıdır yani referans tip de olmasına rağmen interface yada abstract sınıflar buraya giremez.      
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
