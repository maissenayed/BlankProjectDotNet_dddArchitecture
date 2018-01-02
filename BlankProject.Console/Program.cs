using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using BlankProject.Data;
using BlankProject.Domain.Entities;

namespace BlankProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var ctx = new MyContext())
            {
                Example A = new Example();
                ctx.Examples.Add(A);
                ctx.SaveChanges();

            }
        }
    }
}
