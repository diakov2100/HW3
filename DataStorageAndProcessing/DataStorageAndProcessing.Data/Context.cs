using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataStorageAndProcessing.Data
{
    public class Context: DbContext
    {
        public DbSet<Location> Location { get; set; }
        public DbSet<Institution> Institution { get; set; }
        public DbSet<InstitutionRaiting> InstiutionRaitings { get; set; }
        public Context() : base("localsql")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institution>()
                .HasRequired<InstitutionRaiting>(a=>a.Id)
            //base.OnModelCreating(modelBuilder);
        }
    }
}
