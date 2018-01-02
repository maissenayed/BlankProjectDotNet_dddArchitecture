using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BlankProject.Data.Infrastructure;

namespace BlankProject.ServicePattern
{
    //instancier UnitOf Work
    public class Service<T> : IService<T> where T : class
    {
        
        private UnitOfWork utw;

        public Service(UnitOfWork utw)
        {
            this.utw = utw;
        }
        public void Add(T entity)
        {
            utw.GetRepository<T>().Create(entity);
        }

        public void Supprimer(T entity)
        {
            utw.GetRepository<T>().Remove(entity);
                
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public T FindById(string id)
        {
            return utw.GetRepository<T>().FindById(id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expression<Func<T, bool>> condition)
        {
            utw.GetRepository<T>().Remove(condition);
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> @orderby = null)
        {
            return utw.GetRepository<T>().FindByCondition(condition, orderby);
        }
    };

}
