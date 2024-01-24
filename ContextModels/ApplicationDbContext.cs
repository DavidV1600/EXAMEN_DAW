namespace Test_Examen.ContextModels
{
    using Microsoft.EntityFrameworkCore;
    using Test_Examen.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autori { get; set; }
        public DbSet<Carte> Carti { get; set; }
        public DbSet<Editura> Edituri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carte>()
                .HasOne(c => c.Autor)
                .WithMany(a => a.Carti)
                .HasForeignKey(c => c.AutorId);

            modelBuilder.Entity<Carte>()
                .HasOne(c => c.Editura)
                .WithMany(e => e.Carti)
                .HasForeignKey(c => c.EdituraId);

            base.OnModelCreating(modelBuilder);
        }
    }
}