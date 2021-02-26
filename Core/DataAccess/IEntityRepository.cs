using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generik constarint: cenerik kısıt 
    //class:buradaki class referans tip olabilir demek
    //IEntity:IEntity olabilir ya da IEntity implemente eden nesne olabilir
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filtre vermek zorunda değilsin demek
        T Get(Expression<Func<T, bool>> filter);//filtre gerekli olduğunu belirtir.tek data getirir
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
