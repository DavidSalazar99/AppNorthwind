using App_Northwind.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Northwind.bd
{
    public class Contexto : DbContext
    {
        public Contexto() : base("NorthwindContexto") { }
        public DbSet <Region> Regiones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Region>().Property(Entidad => Entidad.RegionID);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
