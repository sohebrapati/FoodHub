namespace FoodHub.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodHubEFModel : DbContext
    {
        public FoodHubEFModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<MasterCategory> MasterCategory { get; set; }
        public virtual DbSet<MasterCategoryImages> MasterCategoryImages { get; set; }
        public virtual DbSet<MasterCity> MasterCity { get; set; }
        public virtual DbSet<MasterCountry> MasterCountry { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantCategory> RestaurantCategory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<MasterCity>()
                .Property(e => e.Latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<MasterCity>()
                .Property(e => e.Longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<MasterCity>()
                .HasMany(e => e.Restaurant)
                .WithRequired(e => e.MasterCity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MasterCountry>()
                .Property(e => e.CurrencyDecimalSeparator)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MasterCountry>()
                .Property(e => e.Latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<MasterCountry>()
                .Property(e => e.Longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Latitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.Longitude)
                .HasPrecision(12, 9);

            modelBuilder.Entity<Restaurant>()
                .Property(e => e.PriceBucket)
                .IsFixedLength();
        }
    }
}
