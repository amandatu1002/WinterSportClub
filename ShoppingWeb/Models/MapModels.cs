namespace ShoppingWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MapModels : DbContext
    {
        public MapModels()
            : base("name=MapModels")
        {
        }

        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .Property(e => e.C_Name_)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Latitude)
                .HasPrecision(10, 8);

            modelBuilder.Entity<Location>()
                .Property(e => e.Longitude)
                .HasPrecision(11, 8);
        }
    }
}
