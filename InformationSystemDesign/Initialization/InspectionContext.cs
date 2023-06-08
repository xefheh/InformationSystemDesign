using System.Reflection;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Initialization
{
    public sealed class InspectionContext : DbContext
    {
        public DbSet<AnimalCard> AnimalCards { get; set; }
        public DbSet<MunicipalCard> MunicipalCards { get; set; }
        public DbSet<OrganizationCard> OrganizationCards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InspectionCard> InspectionCards { get; set; }

        public DbSet<LocalityCard> LocalityCards { get; set; }

        public InspectionContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=inspection.db");
    }
}
