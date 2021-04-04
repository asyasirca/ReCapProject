using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        //TEntity ve TContext için kurallar koyuyoruz
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern denen bir implementasyonu
            //çöp toplayıcıya using bitince gel topla al bunları der.
            using (TContext context = new TContext())//vid8..1:47
            {
                //var...değişkeni tanımlamadan karşısına ne atanırsa o veri tipi olan yapıdır.
                //addedEntity...eklenen varlık.bu bir değişken
                var addedEntity = context.Entry(entity);//git veri kaynağından benim bu gönderdiğim car ile nesneyi eşleştir.slında ekle
                addedEntity.State = EntityState.Added;
                context.SaveChanges();//vid8 1:52
            }

        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)//get tek data getirir
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext()) //eğerki filtre göndermemişse veritabanındaki tüm datayı getir.filtre vermişse filtredeki bilgiyi getir
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
                //eğer filtre null ise ilk kısım değilse ikinci kısım çalışır
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
