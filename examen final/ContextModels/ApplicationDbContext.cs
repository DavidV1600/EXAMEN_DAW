using Microsoft.EntityFrameworkCore;
using Test_Examen.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Profesor> Profesori { get; set; }
    public DbSet<Materie> Materii { get; set; }
    public DbSet<Profesor_Materie> MateriiProfesori { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)//pun cheia primara pentru Profesor_Materie
    {
        modelBuilder.Entity<Profesor_Materie>()
            .HasKey(mp => new { mp.MaterieId, mp.ProfesorId });
    }
}