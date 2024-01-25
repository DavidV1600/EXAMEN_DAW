﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Test_Examen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Test_Examen.Models.Materie", b =>
                {
                    b.Property<int>("MaterieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterieId"), 1L, 1);

                    b.Property<int>("Credite")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterieId");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("Test_Examen.Models.Profesor", b =>
                {
                    b.Property<int>("ProfesorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfesorId"), 1L, 1);

                    b.Property<bool>("EsteLaborant")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfesorId");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("Test_Examen.Models.Profesor_Materie", b =>
                {
                    b.Property<int>("MaterieId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("MaterieId", "ProfesorId");

                    b.ToTable("MateriiProfesori");
                });
#pragma warning restore 612, 618
        }
    }
}
