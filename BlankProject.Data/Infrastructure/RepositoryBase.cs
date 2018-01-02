using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BlankProject.Data.Infrastructure
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T:class
    {
        private MyContext ctx;
        public MyContext MyContext { get { return ctx; } }
        private static DbSet<T> dbset = null;


        public RepositoryBase(DatabaseFactory dbfactory )
        {
            ctx = dbfactory.MyContext;
            dbset = ctx.Set<T>();
        }

        public void Commit()
        {
            
        }
        public void Create(T entity)
        {
            dbset.Add(entity);
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

        public T FindById(int id)
        {
            return dbset.Find(id);
        }

        public T FindById(string id)
        {
            return dbset.Find(id);
        }

        public void Update(T entity)
        {
            // attacher l'entité au dbset
            dbset.Attach(entity);
            //ecraser l'ancien obj par le nouveau
            MyContext.Entry(entity).State=EntityState.Modified;
        }

        public void Remove(Expression<Func<T,bool>> condition)
        {
            IEnumerable<T> maListe = dbset.Where(condition);
            foreach (T item in maListe)
            {
                dbset.Remove(item);
            }
            
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T,bool>> condition = null, Expression<Func<T,bool>> orderby = null)
        {
            if (condition == null && orderby == null)
            {
                return dbset;
            }
            else if (condition==null && orderby!=null)
            {
                return dbset.OrderBy(orderby);
            }
            else if (condition != null && orderby != null)
            {
                return dbset.Where(condition).OrderBy(orderby);

            }

            return dbset.Where(condition);
        }
    }
}
