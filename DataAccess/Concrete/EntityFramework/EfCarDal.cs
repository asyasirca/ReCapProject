using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //IDisposable pattern denen bir implementasyonu
            //çöp toplayıcıya using bitince gel topla al bunları der.
            using (ReCapContext context=new ReCapContext())//vid8..1:47
            {
                //var...değişkeni tanımlamadan karşısına ne atanırsa o veri tipi olan yapıdır.
                //addedEntity...eklenen varlık.bu bir değişken
                var addedEntity = context.Entry(entity);//git veri kaynağından benim bu gönderdiğim car ile nesneyi eşleştir.slında ekle
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//vid8 1:52
            }

        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)//get tek data getirir
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context =new  ReCapContext()) //eğerki filtre göndermemişse veritabanındaki tüm datayı getir.filtre vermişse filtredeki bilgiyi getir
            {
                return filter == null 
                    ? context.Set<Car>().ToList() 
                    : context.Set<Car>().Where(filter).ToList();
                //eğer filtre null ise ilk kısım değilse ikinci kısım çalışır
            }
        }

        public void Update(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
