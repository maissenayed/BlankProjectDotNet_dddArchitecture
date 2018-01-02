using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankProject.Data.Infrastructure;
using BlankProject.Domain.Entities;
using BlankProject.ServicePattern;

namespace BlankProject.Service
{
    class ExampleService:Service<Example>
    {
        //static to not be changed outside of the construct
        static DatabaseFactory dbFactory = new DatabaseFactory();
        static UnitOfWork utw = new UnitOfWork(dbFactory);
        public ExampleService(UnitOfWork utw) : base(utw)
        {
        }

        /*

        public List<Example> Question1()
        {
            return utw.GetRepository<Example>()
                .FindByCondition(e => e.Credits.Where(s => s.SommeCredit > 10000).Count() > 0).OrderBy(e => e.Solde).ToList();
        }*/


    }
}
