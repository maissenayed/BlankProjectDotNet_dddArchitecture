using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlankProject.ServicePattern
{
    public interface IService<T> where T:class 
    {
        void Add(T entity);
        void Supprimer(T entity);
        T FindById(int id);
        T FindById(string id);
        void Update(T entity);
        //IEnumerable<T> FindAll();
        void Remove(Expression<Func<T, bool>> condition);//Lambda expression declaration type
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderby = null

        );
    }
}
