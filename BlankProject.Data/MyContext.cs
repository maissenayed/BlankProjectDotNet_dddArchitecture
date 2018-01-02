using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlankProject.Domain.Entities;

namespace BlankProject.Data
{
   public class MyContext:DbContext
    {   
        public MyContext() : base(/*"nom de base"*/) { }

        public DbSet<Example> Examples { get; set; }


        //configuration fluent api
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*dbModelbuilder: takes configuration rules and applies them when migrations happen or context intiliazer happens
            works sur le contenu des colones */
            //example
            //modelBuilder.Configurations.Add(new CategoryConfiguration());

            //configure chaque prop de type int32 qui se termine par Key comme etant clé primaire
            modelBuilder.Properties<int>()
                .Where(p => p.Name == " Key")
                .Configure(p => p.IsKey());



        }




    }
}
