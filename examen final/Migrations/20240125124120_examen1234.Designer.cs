﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Test_Examen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240125124120_examen1234")]
    partial class examen1234
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("ProfesorId");

                    b.ToTable("MateriiProfesori");
                });

            modelBuilder.Entity("Test_Examen.Models.Profesor_Materie", b =>
                {
                    b.HasOne("Test_Examen.Models.Materie", "Materie")
                        .WithMany("MateriiProfesori")
                        .HasForeignKey("MaterieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_Examen.Models.Profesor", "Profesor")
                        .WithMany("MateriiProfesori")
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materie");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Test_Examen.Models.Materie", b =>
                {
                    b.Navigation("MateriiProfesori");
                });

            modelBuilder.Entity("Test_Examen.Models.Profesor", b =>
                {
                    b.Navigation("MateriiProfesori");
                });
#pragma warning restore 612, 618
        }
    }
}