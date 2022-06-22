using Microsoft.EntityFrameworkCore;
using Personelinformation.Data.Config;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Data.Concrete.EfCore
{
    public class PersonelContext : DbContext
    {
        public DbSet<Information> Informations { get; set; }
        public DbSet<PersonelInformation> PersonelInformations { get; set; }
        public DbSet<DetailInformation> DetailInformations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=MK\\SQLEXPRESS; integrated security=true ; database=InformationApiDB; ");
            optionsBuilder.UseSqlite("Data Source=InformationApiDB; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InformationConfig).Assembly);
            

            
        }

    }
}
