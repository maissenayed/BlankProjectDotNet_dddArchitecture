using System.Data.Entity.ModelConfiguration;
using BlankProject.Domain.Entities;

namespace BlankProject.Data.Configuration
{
    public class CompteConfiguration:EntityTypeConfiguration<Example>/*the class that you want to configure*/
    {
        public CompteConfiguration()
        {


            //discriminateur value example
            //this.Map<"class qui herite de la mere">(m => m.Requires("type").HasValue("la valeur"));
            //this.Map<"class qui herite de la mere">(m => m.Requires("type").HasValue("la valeur"));

            // this.HasOptional<Credit>(c => c.Credits).WithMany(c => c.Comptes).HasForeignKey(s => s.Credits);

            /*
            //ManytoMany
            HasMany(p => p.Credits).WithMany(pr => pr.Comptes).Map(t =>
            {
                //une seule variable parceque le mapping va se faire dans une seule table
                
                t.MapLeftKey("Compte");//parent entity
                t.MapRightKey("Credit");

            });



            //OnetoMany 
            //0..* HasOptional()
            //1..* HasRequired()
            this.HasRequired(p => p.Agence)
                .WithMany(c => c.Comptes)
                .HasForeignKey(p => p.AgenceId)
                .WillCascadeOnDelete(false);// will delete product only , doesn't delete category too




            //OnetoMany 
            //0..* HasOptional()
            //1..* HasRequired()
            this.HasRequired(p => p.Client)
                .WithMany(c => c.Comptes)
                .HasForeignKey(p => p.Cin)
                .WillCascadeOnDelete(false);// will delete product only , doesn't delete category too
    */
        }
    }
       


}

