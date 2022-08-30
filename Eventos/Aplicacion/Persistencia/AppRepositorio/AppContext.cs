using Microsoft.EntityFrameworkCore;
using Dominio;



namespace Persistencia
{
   public class AppContext:DbContext
   {
    //Atributos
    public DbSet<Municipio> Municipios {get;set;}
    public DbSet<Patrocinador> Patrocinadores {get;set;}
    public DbSet<Colegio> colegios {get;set;}

    public DbSet<Torneo> Torneos {get;set;}

    public DbSet <UnidadDeportiva> UnidadDeportivas {get;set;}


    // crear la conexion con la base datos
    protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
    {
        if (!OptionsBuilder.IsConfigured){

            OptionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Eventos30");
            

              //(localdb)\\MSSQLLocalDB
        }
    }
   }
}