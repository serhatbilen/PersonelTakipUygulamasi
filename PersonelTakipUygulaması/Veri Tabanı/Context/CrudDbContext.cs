using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulaması.Veri_Tabanı.Context
{
    public class CrudDbContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public CrudDbContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-EOJLM51;database=PersonnelTracking; Trusted_Connection=true";
        }

        public DbSet<Departman> departman { get; set; }
        public DbSet<Calisan> calisan { get; set; }
    }
}
