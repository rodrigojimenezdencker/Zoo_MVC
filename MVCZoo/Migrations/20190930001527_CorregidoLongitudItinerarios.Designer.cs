﻿// <auto-generated />
using MVCZoo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCZoo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20190930001527_CorregidoLongitudItinerarios")]
    partial class CorregidoLongitudItinerarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCZoo.Models.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre_Cientifico");

                    b.Property<string>("Nombre_Comun");

                    b.HasKey("Id");

                    b.ToTable("Especie");
                });

            modelBuilder.Entity("MVCZoo.Models.Habitat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clima");

                    b.Property<int>("ItinerarioId");

                    b.Property<string>("Nombre");

                    b.Property<string>("Vegetacion");

                    b.HasKey("Id");

                    b.HasIndex("ItinerarioId");

                    b.ToTable("Habitat");
                });

            modelBuilder.Entity("MVCZoo.Models.Itinerario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo");

                    b.Property<int>("Duracion");

                    b.Property<int>("Longitud");

                    b.Property<int>("Visitantes");

                    b.HasKey("Id");

                    b.ToTable("Itinerario");
                });

            modelBuilder.Entity("MVCZoo.Models.Viven", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EspecieId");

                    b.Property<int>("HabitatId");

                    b.Property<int>("Indice");

                    b.HasKey("Id");

                    b.HasIndex("EspecieId");

                    b.HasIndex("HabitatId");

                    b.ToTable("Viven");
                });

            modelBuilder.Entity("MVCZoo.Models.Habitat", b =>
                {
                    b.HasOne("MVCZoo.Models.Itinerario", "Itinerario")
                        .WithMany("Habitats")
                        .HasForeignKey("ItinerarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MVCZoo.Models.Viven", b =>
                {
                    b.HasOne("MVCZoo.Models.Especie", "Especie")
                        .WithMany("Viven")
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MVCZoo.Models.Habitat", "Habitat")
                        .WithMany("Viven")
                        .HasForeignKey("HabitatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
