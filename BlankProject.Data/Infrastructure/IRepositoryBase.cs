using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlankProject.Data.Infrastructure
{
    interface IRepositoryBase<T> where T:class
    {
        void Create(T entity);
        void Remove(T entity);
        T FindById(int id);
        T FindById(string id);
        void Update(T entity);
        //IEnumerable<T> FindAll();
        //bool vérifie si les informations de T sont vrai ou non
        void Remove(Expression<Func<T,bool>> condition);
        //pas besoin d'utiliser la méthode getAll()
        IEnumerable<T> FindByCondition(
            Expression<Func<T,bool>> condition=null, 
            Expression<Func<T,bool>> orderby = null

            );

    }
}
